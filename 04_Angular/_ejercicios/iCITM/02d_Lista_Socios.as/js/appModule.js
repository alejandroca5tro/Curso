angular.module("appModule", [])
.controller('AppController', function(){

	this.aSocios = ["Andrés","María","Luis","Carmen","Antonio"];	
	

	this.AddSocio = function () {
		this.aSocios.push(this.nuevoSocio);
		this.nuevoSocio = '';
	}
})
