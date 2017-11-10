'use strict';

// STAGE5 - Zakomentowac
//angular.module('newsListApp', ['ngRoute'])
//.config(['$routeProvider', '$httpProvider', '$locationProvider', function ($routeProvider, $httpProvider, $locationProvider) {
//    $routeProvider.when("/Home", {
//        controller: "homeController",
//        templateUrl: "/App/Views/Home.html",
//    }).when("/NewsList", {
//        controller: "newsListController",
//        templateUrl: "/app/views/newslist.html",
//    }).when("/AddNews", {
//        controller: "addNewsController",
//        templateUrl: "/app/views/AddNews.html",
//    }).otherwise({ redirectTo: "/Home" });
//    $locationProvider.hashPrefix('');
//}]);

// STAGE5 - Odkomentowac do konca pliku
angular.module('newsListApp', ['ngRoute', 'AdalAngular'])
.config(['$routeProvider', '$httpProvider', '$locationProvider', 'adalAuthenticationServiceProvider', function ($routeProvider, $httpProvider, $locationProvider, adalProvider) {
    $routeProvider.when("/Home", {
        controller: "homeController",
        templateUrl: "/App/Views/Home.html"
    }).when("/NewsList", {
        controller: "newsListController",
        templateUrl: "/app/views/newslist.html"
    }).when("/AddNews", {
        controller: "addNewsController",
        templateUrl: "/app/views/AddNews.html",
        requireADLogin: true
    }).otherwise({ redirectTo: "/Home" });
    $locationProvider.hashPrefix('');
    // STAGE5 - Skonfigurowac sciezke do api oraz clientId
    var endpoints = {
        "https://azure-training-01-api.azurewebsites.net/api": '6e8df08f-5632-4418-8989-6e5e5a550aa9' 
    };
    // STAGE5 - Skonfigurowac tenant oraz clientId
    adalProvider.init(
        {
            instance: 'https://login.microsoftonline.com/',
            tenant: 'architektwchmurze.pl',
            clientId: 'c81566ab-5dc8-48ba-95dc-efdca5885032',
            extraQueryParameter: 'nux=1',
            endpoints: endpoints
        },
        $httpProvider
        );
}]);