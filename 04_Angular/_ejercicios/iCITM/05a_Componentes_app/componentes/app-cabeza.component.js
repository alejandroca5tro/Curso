class AppCabeza {

    $onInit () {
        this.sTitulo = "Componentes en Angular 1.6";
    }

} // Fin de la clase AppCabeza


angular.module('appPrueba')
.component("appCabeza", {
    //require: {'parent' : 'MainController'},
    templateUrl : 'componentes/app-cabeza.template.html',
    controller : AppCabeza,
})