class AddTexto {

    constructor ($scope) {
        this.$scope = $scope;
    }


    $onInit () {
        //this.texto = "Hola";
        console.info("Componente ADDTEXTO");
        console.dir(this);
        this.texto = this.parent.texto;
       
    }

}

angular.module('appPrueba')
.component("addTexto", {
    require: {parent : '^appMain'},
    templateUrl : 'componentes/addTexto.template.html',
    controller : AddTexto
})