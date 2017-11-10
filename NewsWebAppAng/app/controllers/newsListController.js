'use strict';

angular.module('newsListApp')
.controller('newsListController', ['$scope', '$location', 'newsService', function ($scope, $location, newsService) {
    $scope.error = "";
    $scope.loadingMessage = "Loading...";
    $scope.newsListAbc = null;

    $scope.populate = function () {
        newsService.getAllNews().then(function (data) {
            $scope.newsListAbc = data;
            $scope.loadingMessage = "";
        })
    }; 
}]);
