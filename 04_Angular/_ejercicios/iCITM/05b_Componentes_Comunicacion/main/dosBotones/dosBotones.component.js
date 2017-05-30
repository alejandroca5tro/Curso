class DosBotones {

    constructor($scope) {
        this.$scope = $scope;
    }

    $onInit () {        
    }

    clickBoton(pBoton) {
       console.log("Pulsado Boton " + pBoton)               
       this.$scope.$emit("PRESS_BT", pBoton)
    }


}

angular.module('appMain')
.component("dosBotones", {
    templateUrl : 'main/dosBotones/dosBotones.template.html',
    controller : DosBotones,
    bindings : {
       boton1 : "<btn1",
       boton2 : "<btn2",
    }
})
