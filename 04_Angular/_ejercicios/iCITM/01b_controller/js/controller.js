angular.module("miApp")

.controller("MainController", ["$scope", function($scope) { // Si queremos inyectar variables, debemos indicarlas entre comillas para salvarlas del mimificado. Esto es de Angular, no de JS.
    $scope.nombre = 'Pepe'; //aquí si hay que poner $scope
    $scope.nuevoPensamiento = ''; // declaracion innecesaria pero recomendable
    $scope.aPensamientos = [];

    $scope.botonAdd = function() {
        $scope.aPensamientos.push($scope.nuevoPensamiento);
        $scope.nuevoPensamiento = '';
    }
}]); // fin de Maincontroller