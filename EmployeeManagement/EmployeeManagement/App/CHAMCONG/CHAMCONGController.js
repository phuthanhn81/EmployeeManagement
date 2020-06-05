app.controller("CHAMCONGController", CHAMCONG)
CHAMCONG.$inject = ['$scope', '$http'];
function CHAMCONG($scope, $http) {
    $scope.MABP;
    $scope.BOPHAN;
    $http({
        method: 'GET',
        url: 'http://localhost:56039/api/bophan/all',
        dataType: 'json',
    }).then(function successCallback(response) {
        $scope.BOPHAN = response.data.listbp;
        $scope.MABP = $scope.BOPHAN[0].MABP;
    });

    // nó sẽ render hết cái repeat đó rồi mới vào bên trong (loop xếp chồng)
    // render xong 31 ngoài rồi 31 trong cứ thế tiếp tục nhưng nhờ track by $index nên nó nhớ bắt đầu từ 0 tại repeat nào
    // render hết tag sẽ chạy ng- trừ ng-repeat(ưu tiên) thì sẽ render hết cái tag td có repeat đó, riêng cái "{{}}" ko tính là ng-

    // 1 cái gán, 1 cái so sánh
    $scope.ss = 0;
    $scope.pos = 0; // ko có pos đó sẽ = undefined 2 way binding cẩn thận khi ++ 
    $scope.Check = function (Column, Day, n) {
        if (Column == 1) { // cột 1 = new row
            $scope.pos = 0; // listbc của người khác
        }
        if (Column == Day) { // cột 1 = ngày 1, cột 20 = ngày 20
            $scope.ss++; // gán thành công so sánh bảng công kế tiếp
            $scope.pos = $scope.ss - 1; // 2 way binding -> gán là gán vị trí hiện tại so sánh là ss vị trí kế tiếp
            if ($scope.ss == n) { // hết listbc
                $scope.ss = 0;
            }
            return true;
        }
        return false;
    }

    $scope.Days = 0;
    $scope.Update = function () {
        if ($scope.TIME != null) {
            $scope.BANGCONG;
            $http({
                method: 'GET',
                url: 'http://localhost:56039/api/chamcong/all',
                params: {
                    MABP: $scope.MABP,
                    DATE: new Date($scope.TIME),
                },
                headers: { 'Content-Type': 'application/json' },
                dataType: 'json',
            }).then(function successCallback(response) {
                $scope.BANGCONG = groupByMulti(response.data.listbc, ['MANV', 'HOTEN']);
                $scope.Days = response.data.days;
                console.log($scope.BANGCONG);
            });
        }
    }
}

function groupByMulti(list, values, context) {
    if (!values.length) {
        return list;
    }
    var byFirst = _.groupBy(list, values[0], context),
        rest = values.slice(1);
    for (var prop in byFirst) {
        byFirst[prop] = groupByMulti(byFirst[prop], rest, context);
    }
    return byFirst;
}

app.controller('OptionsCtrl', WithOptionsCtrl);
function WithOptionsCtrl(DTOptionsBuilder) {
    var vm = this;
    vm.dtOptions = DTOptionsBuilder.newOptions()
        .withPaginationType('full_numbers')
        .withOption('scrollY', '300px')
        .withOption('scrollX', true)
        .withOption('scrollCollapse', true)
        .withFixedColumns({
            leftColumns: 2,
        });
}