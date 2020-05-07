(function (app) {
    'use strict';

    app.controller('purchaseOrderCtrl', purchaseOrderCtrl);

    purchaseOrderCtrl.$inject = ['$scope'];

    function purchaseOrderCtrl($scope) {

        var vm = $scope;
        vm.title = 'purchaseOrderCtrl';

        init();

        function init() {

        }
        vm.list = ["name", "namme1"];
        vm.search = function (value) {
            
        };
    }

})(angular
    .module('LpgApp'));
