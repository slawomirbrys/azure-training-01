'use strict';

angular.module('newsListApp')
.controller('addNewsController', ['$scope', '$location', 'newsService', function ($scope, $location, newsService) {
    $scope.error = "";
    $scope.news = {
        title: "",
        body: ""
    }

    $scope.addNews = function () {

        $scope.news.title = $scope.newsTitle;
        $scope.news.body = $scope.newsBody;

        newsService.postNews($scope.news).then(function (data) {
            alert('ok');
        })
    };

}]);
