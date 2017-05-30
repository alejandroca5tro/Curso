angular.module("appModule", [])
.controller('AppController', ['$scope', function($scope){

	$scope.titulo = "Muestrario";
	$scope.isHidden = true;
	$scope.btnColores = function() {
		$scope.isHidden = $scope.isHidden ? false : true ;
	};	
	
}])
