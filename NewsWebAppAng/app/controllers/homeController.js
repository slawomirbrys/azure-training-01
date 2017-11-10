'use strict';

// STAGE5 - Zakomentowac
//angular.module('newsListApp')
//.controller('homeController', ['$scope', '$location', function ($scope, $location) {
//    $scope.isActive = function (viewLocation) {
//        return viewLocation === $location.path();
//    };
//}]);



// STAGE5 - Odkomentowac
angular.module('newsListApp')
.controller('homeController', ['$scope', 'adalAuthenticationService','$location', function ($scope, adalService, $location) {
    $scope.login = function () {
        adalService.login();
    };
    $scope.logout = function () {
        adalService.logOut();
    };
    $scope.isActive = function (viewLocation) {        
        return viewLocation === $location.path();
    };
}]);