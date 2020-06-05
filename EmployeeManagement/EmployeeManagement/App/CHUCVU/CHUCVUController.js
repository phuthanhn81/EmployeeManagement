app.controller("CHUCVUController", CHUCVU)
CHUCVU.$inject = ['$scope', '$http', 'factory'];
function CHUCVU($scope, $http, factory) {
    $scope.data.MACV;
    $scope.CHUCVU;
    $http({
        method: 'GET',
        url: 'http://localhost:56039/api/chucvu/all',
        dataType: 'json',
    }).then(function successCallback(response) {
        $scope.CHUCVU = response.data.listcv;
        $scope.data.MACV = $scope.CHUCVU[0].MACV;

        // use "data" ko cần sài factory, ở project này chỉ là ghi chú cho biết
        if (factory.MACV == '') { // Create | 1st vào Create or Update
            factory.MACV = $scope.data.MACV; // value pos 0
        }
        else { // Update
            $scope.data.MACV = factory.MACV;
        }
    });

    $scope.Update = function (value) { // event
        factory.MACV = $scope.data.MACV; // options change -> model change
    }
}

// nó sẽ chạy $http sau cùng
