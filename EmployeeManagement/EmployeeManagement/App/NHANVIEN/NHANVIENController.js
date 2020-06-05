app.controller("NHANVIENController", NHANVIEN)
NHANVIEN.$inject = ['$scope', '$http', '$location', '$state', 'factory', '$stateParams'];
function NHANVIEN($scope, $http, $location, $state, factory, $stateParams) {
    $scope.Employees = factory.Employees;

    if ($scope.Employees.length === 0) {
        $http({
            method: 'GET',
            url: 'http://localhost:56039/api/nhanvien/all',
            dataType: 'json',
        }).then(function successCallback(response) {
            console.log(response.data.listnv);

            // cả 2 cùng trỏ đến 1 vùng nhớ -> 1 in 2 change sẽ làm cả 2 change
            $scope.Employees = response.data.listnv;
            factory.Employees = response.data.listnv;
        })
    } // All

    var nhanvien = null;
    $scope.Open = function (nv) {
        var confirm = 'Bạn có chắc muốn xóa nhân viên ' + nv.HOTEN + ' ?';
        $('#delete_nv').modal('show');
        $('#confirm').html(confirm);
        nhanvien = nv;
    }
    $scope.Delete = function () {
        $http({
            method: 'DELETE',
            url: 'http://localhost:56039/api/nhanvien/delete',
            data: JSON.stringify(nhanvien),
            headers: { 'Content-Type': 'application/json' },
            dataType: 'json',
        }).then(function successCallback(response) {
            var MANV = response.data.nv.MANV;
            $('#confirm').html('Xóa thành công nhân viên ' + MANV);
            setTimeout(function () {
                $('#delete_nv').modal('hide');

                $('#' + MANV).parents('tr').remove();
                $scope.Employees = $scope.Employees.filter(n => n.MANV !== MANV); // đổ lại data
                factory.Employees = $scope.Employees;

                console.log($scope.Employees);
                console.log(factory.Employees);
                // $state.go('nhanvien', {}, { reload: 'nhanvien' });
                // $location useless if call again templateUrl           
            }, 1000)
        }, function errorCallback(error) {
            var obj = $.parseJSON(error.data.Message);
            var ngaysinh = new Date(parseInt(obj.NGAYSINH.substr(6)));

            $('#confirm').html('Xóa thất bại nhân viên ' + obj.MANV);
            setTimeout(function () {
                $('#delete_nv').modal('hide');
            }, 1000)
        });
    } // Delete

    if ($state.current.name == 'create_nv') {
        factory.MACV = '';
        factory.MABP = '';
    } // fix xung đột với Update (lưu value cũ)
    $scope.Create = function (nv, invalid) {
        if (!invalid) {
            $http({
                method: 'POST',
                url: 'http://localhost:56039/api/nhanvien/create',
                data: JSON.stringify(nv),
                dataType: 'json',
                headers: { "Content-Type": "application/json" }
            }).then(function (response) {
                $scope.Employees.push(response.data.result);
                console.log($scope.Employees);

                factory.Employees = $scope.Employees;
                console.log(factory.Employees);

                $location.path('/nhanvien');
            }, function (error) {
                console.log('error');
            });
        }
    } // Create (data thực chất là 1 Object)

    $scope.data = {};
    if ($stateParams.employee != null) {
        var nv = $stateParams.employee;
        // $scope.data = nv; // có thể dùng cách này
        $scope.data.MANV = nv.MANV;
        $scope.data.HOTEN = nv.HOTEN;
        $scope.data.NGAYSINH = new Date(nv.NGAYSINH); //
        $scope.data.EMAIL = nv.EMAIL;
        $scope.data.CMND = nv.CMND;
        $scope.data.SDT = nv.SDT;
        $scope.data.PHAI = nv.PHAI;
        factory.MACV = nv.MACV; //
        factory.MABP = nv.MABP; //
    }
    $scope.Update = function (nv, invalid) {
        if (!invalid) {
            $http({
                method: 'PUT',
                url: 'http://localhost:56039/api/nhanvien/update',
                data: JSON.stringify(nv),
                dataType: 'json',
                headers: { "Content-Type": "application/json" }
            }).then(function (response) {
                const index = factory.Employees.map(n => n.MANV).indexOf(response.data.result.MANV);
                factory.Employees.splice(index, 1, response.data.result); // xóa n items start từ index
                $location.path('/nhanvien');

                console.log(index);
            }, function (error) {
                console.log('error');
            });
        }
    } // Update (data thực chất là 1 Object)
}

// $state.go("update_nv", { employee: đối số }); có thể dùng ng-click nhưng load lại trang thì mất data (lưu var global)
