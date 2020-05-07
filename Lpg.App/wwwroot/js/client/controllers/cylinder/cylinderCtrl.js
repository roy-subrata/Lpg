

    (function (app) {
        'use strict';

        app.controller('cylinderCtrl', cylinderCtrl);
        cylinderCtrl.$inject = ['$scope'];


        function cylinderCtrl($scope) {

            var vm = $scope;
          //  var dataSvc = cylinderDataSvc;
            vm.title = "Lpg App";


            
        }

    })(angular
        .module('LpgApp'));
