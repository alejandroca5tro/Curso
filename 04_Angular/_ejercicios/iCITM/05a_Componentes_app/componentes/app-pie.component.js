class AppPie {

	$onInit () {

		this.sAutor = "Alejandro Cerezo";
		this.sEmpresa = "CAS Training";
		this.fecha = new Date();
	}

} // Fin de la clase AppCabeza


angular.module('appPrueba')
.component("appPie", {
	//require: {'parent' : 'MainController'},
	templateUrl : 'componentes/app-pie.template.html',
	controller : AppPie,
})