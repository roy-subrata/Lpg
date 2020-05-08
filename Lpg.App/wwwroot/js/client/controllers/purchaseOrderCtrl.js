(function (app) {
    'use strict';

    app.directive('rAuto', function () {

        return {
            restric: "A",
            template: `
            <ul id="n" ng-repeat="v in [1,23,34]">
              <li>{{v}</li>
            </ul>
            `,
            link: function (scope, element, attr) {
                console.log("scope" + scope);
                console.log("scope" + element);
                console.log("scope" + attr);
                if (attr["items"] != null) {

                    //  scope.itms = attr['items'];

                    var myimg = angular.element(element)[0];
                    // var text = document.createElement("p");
                    // text.innerText = "sdsd";
                    // myimg.insertAdjacentElement('afterend', text);
                    var r = document.getElementById("n");
                    myimg.insertAdjacentElement('afterend', r);


                }
            }
        }
    })
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
