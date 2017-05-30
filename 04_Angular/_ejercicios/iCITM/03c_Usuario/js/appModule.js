angular.module("appModule", [])
.controller('AppController', ['$scope', function($scope){

	$scope.oUsuario = {
		nombre: 'PEPE',
		apellido: 'PEREZ',
		fechaAlta: new Date(2010, 2, 23),
		consumoDatos: 123.659855,
		plan: 'plan-super-basico'
	};	
	
}])
