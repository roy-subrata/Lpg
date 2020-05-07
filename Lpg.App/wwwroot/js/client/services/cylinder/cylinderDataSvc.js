(function (app) {
    'use strict';

    app.factory('cylinderDataSvc', cylinderDataSvc);

    cylinderDataSvc.$inject = ['$http','$q'];

    function cylinderDataSvc($http,$q){
        var service = {
            getClylinders: getClylinders
        };

        return service;

        function getClylinders() {
            
            var defer = $q.derfer();
            $http.get("http://localhost:5001/api/cylinders");
      
        }
    }

})(angular
    .module('LpgApp'));
