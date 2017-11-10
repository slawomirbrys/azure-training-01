'use strict';

// STAGE5 - Zakomentowac
angular.module('newsListApp', ['ngRoute'])
.config(['$routeProvider', '$httpProvider', '$locationProvider', function ($routeProvider, $httpProvider, $locationProvider) {
    $routeProvider.when("/Home", {
        controller: "homeController",
        templateUrl: "/App/Views/Home.html",
    }).when("/NewsList", {
        controller: "newsListController",
        templateUrl: "/app/views/newslist.html",
    }).when("/AddNews", {
        controller: "addNewsController",
        templateUrl: "/app/views/AddNews.html",
    }).otherwise({ redirectTo: "/Home" });
    $locationProvider.hashPrefix('');
}]);

//// STAGE5 - Odkomentowac do konca pliku
//angular.module('newsListApp', ['ngRoute', 'AdalAngular'])
//.config(['$routeProvider', '$httpProvider', '$locationProvider', 'adalAuthenticationServiceProvider', function ($routeProvider, $httpProvider, $locationProvider, adalProvider) {
//    $routeProvider.when("/Home", {
//        controller: "homeController",
//        templateUrl: "/App/Views/Home.html"
//    }).when("/NewsList", {
//        controller: "newsListController",
//        templateUrl: "/app/views/newslist.html"
//    }).when("/AddNews", {
//        controller: "addNewsController",
//        templateUrl: "/app/views/AddNews.html",
//        requireADLogin: true
//    }).otherwise({ redirectTo: "/Home" });
//    $locationProvider.hashPrefix('');
//    // STAGE5 - Skonfigurowac sciezke do api oraz clientId
//    var endpoints = {
//        "https://newsapiapp.azurewebsites.net/api": '949ad1d9-cabc-4559-8aeb-e267cb823bc1' 
//    };
//    // STAGE5 - Skonfigurowac tenant oraz clientId
//    adalProvider.init(
//        {
//            instance: 'https://login.microsoftonline.com/',
//            tenant: 'piotrcieslakstellarfox.onmicrosoft.com',
//            clientId: '949ad1d9-cabc-4559-8aeb-e267cb823bc1',
//            extraQueryParameter: 'nux=1',
//            endpoints: endpoints
//        },
//        $httpProvider
//        );
//}]);