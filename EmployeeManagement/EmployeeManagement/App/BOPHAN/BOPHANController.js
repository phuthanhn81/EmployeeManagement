app.controller("BOPHANController", BOPHAN)
BOPHAN.$inject = ['$scope', '$http', 'factory'];
function BOPHAN($scope, $http, factory) {
    $scope.data.MABP;
    $scope.BOPHAN;
    $http({
        method: 'GET',
        url: 'http://localhost:56039/api/bophan/all',
        dataType: 'json',
    }).then(function successCallback(response) {
        $scope.BOPHAN = response.data.listbp;
        $scope.data.MABP = $scope.BOPHAN[0].MABP;

        if (factory.MABP == '') { // Create
            factory.MABP = $scope.data.MABP;
        }
        else { // Update
            $scope.data.MABP = factory.MABP;
        }
    });

    $scope.Update = function (value) {
        factory.MABP = $scope.data.MABP;
    }
}