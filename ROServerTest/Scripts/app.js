angular.module('app', [])
.controller('testCtrl', function ($scope, $http) {

    clearResults();

    $scope.requestCount = 1000;
    $scope.clearResults = clearResults;
    $scope.objectId;
    $scope.random = true;
    $scope.makeRequests = function () {
        if ($scope.random) {
            randomObjectRequests();
        }
        else {
            objectRequestsById();
        }
    };

    $scope.pendingRequests = $http.pendingRequests;

    function clearResults() {
        $scope.errors = [];
        $scope.successes = [];
    }

    function randomObjectRequests() {
        for (var i = 0; i < $scope.requestCount; i++) {
            $http({
                url: "/api/objects/TestModel.TestObject/" + Math.ceil(Math.random() * 1000),
                method: "GET",
            }).
            success(function (data, status, headers, config) {
                $scope.successes.push(data);
                //console.log(data);
            }).
            error(function (data, status, headers, config) {
                console.log(data);
                $scope.errors.push({ data: data, status: status });
            });
        }
    }

    function objectRequestsById() {
        for (var i = 0; i < $scope.requestCount; i++) {
            $http({
                url: "/api/objects/TestModel.TestObject/" + $scope.objectId,
                method: "GET",
            }).
            success(function (data, status, headers, config) {
                $scope.successes.push(data);
            }).
            error(function (data, status, headers, config) {
                console.log(data);
                $scope.errors.push({ data: data, status: status });
            });
        }
    }
});