class DosBotones {

    $onInit () {
        
    }

    clickBoton1() {
        console.log("Pulsado Boton 1")
        console.dir(this)
        this.btn1Clic();
    }

    clickBoton2() {
        this.btn2Clic();
    }

}

angular.module('appPrueba')
.component("dosBotones", {
    templateUrl : 'componentes/dosBotones.template.html',
    controller : DosBotones,
    bindings : {
       boton1 : "<btn1",
       boton2 : "<btn2",
       btn1Clic : "&",
       btn2Clic : "&"

    }
})