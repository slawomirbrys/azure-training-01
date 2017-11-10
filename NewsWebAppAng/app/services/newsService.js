'use strict';

angular.module('newsListApp')
.factory('newsService', ['$http', function ($http) {

    $http.defaults.useXDomain = true;
    delete $http.defaults.headers.common['X-Requested-With'];

    return {
        getAllNews: function () {
            return $http.get(newsApiAppEndpoint + '/anonymous/allnews').then(function (response) {
                return response.data;
            });
        },
        postNews: function (item) {
            return $http.post(newsApiAppEndpoint + '/api/news', item).then(function (response) {
                return response.data;
            });
        }
    };
}]);