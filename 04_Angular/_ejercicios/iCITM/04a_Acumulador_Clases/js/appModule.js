// código del controlador en AngularJS

angular.module("appModule", [])
    .controller('AppController', ['$scope', function($scope) {

        $scope.incremento = 10;
        $scope.total = $scope.incremento;
        $scope.tamTitular = "titulargran";
        $scope.aClases = ["uno", "dos", "tres"];
        $scope.sClases = "uno dos tres";

        //$scope.oClaseTotal = { positivo : ($scope.total >= 0),
        //					   negativo : ($scope.total < 0)}


        $scope.sumar = function() {;
            $scope.total += parseInt($scope.incremento);
        }
        $scope.restar = function() {
            $scope.total -= parseInt($scope.incremento);
        }

    }])