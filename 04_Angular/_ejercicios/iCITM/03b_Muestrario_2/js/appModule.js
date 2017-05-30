angular.module("appModule", [])
.controller('AppController', ['$scope', function($scope){

	$scope.isHidden = true;
	$scope.verColores = function(verOK) {
		$scope.isHidden = !verOK;
		//$scope.isHidden ? false : true ;
	};	
	
}])
