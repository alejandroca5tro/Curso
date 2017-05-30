angular.module("appModule", [])
.controller('AppController', ['$scope', function($scope){
	
		 $scope.aFotos = [ { src : "images/diana_of_bitru_300.jpeg",
				 			  alt : "Diana of Bitru - Luis Royo",
				 			  title : "Diana of Bitru - Luis Royo"},
				 			{ src : "images/eyes_300.jpeg",
				 			  alt : "Eyes - Luis Royo",
				 			  title : "Eyes - Luis Royo"}, 
		     				{ src : "images/fissures_of_the_breeze_300.jpeg",
		     				  alt : "Fissures of the Breeze - Luis Royo",
		     				  title : "Fissures of the Breeze - Luis Royo"},
		 				    { src : "images/golden_kabala_300.jpeg",
		     				  alt : "Golden Kabala - Luis Royo",
		     				  title : "Golden Kabala - Luis Royo"} ];

		 	$scope.iFoto = 0
		 	$scope.isInicio = true;
		 	$scope.isFinal = false;

		    $scope.cambiarFoto = function (direccion) {		    	

		        if (direccion == "next" && $scope.iFoto < $scope.aFotos.length) {
		            $scope.iFoto++;
		        } else if ($scope.iFoto != 0) {
		            $scope.iFoto--;
		        }

		         if ($scope.iFoto == 0) {
					 	$scope.isInicio = true;
				 		$scope.isFinal = false;
                    } else if ($scope.iFoto == $scope.aFotos.length - 1) {
					 	$scope.isInicio = false;
				 		$scope.isFinal = true;
                    } else {
					 	$scope.isInicio = false;
				 		$scope.isFinal = false;
                    }

		    }; // Fin de la función
	
}])
