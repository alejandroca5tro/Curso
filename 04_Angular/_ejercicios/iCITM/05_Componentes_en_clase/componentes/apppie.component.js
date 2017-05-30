class PieController{
    $onInit () {
        this.sAutor = "Alejandro"
        this.sEmpresa = "CAS Training"
        this.fecha = new Date()
    }
}

angular.module('appPrueba')
.component("appPie",{
    templateUrl:'componentes/apppie.template.html',
    controller: PieController
})
