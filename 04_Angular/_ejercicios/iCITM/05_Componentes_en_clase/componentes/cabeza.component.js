class CabezaController{
    $onInit () {
        this.sTitulo="Ejercicio en clase"
    }
}

angular.module('appPrueba')
.component("appCabeza",{
    templateUrl:'componentes/cabeza.template.html',
    controller: CabezaController
})

