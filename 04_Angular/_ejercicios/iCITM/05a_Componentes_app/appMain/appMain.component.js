class MainController {

    $onInit () {
        this.texto = "Texto desde papa";
        this.btn1 = "Enviar"
        this.btn2 = "Borrar"
    }

   botonEnviar() {
        alert ("Boton 1");
    }

   botonBorrar() {
       alert ("Boton 2");
    }

}

angular.module('appPrueba')
.component("appMain", {
    templateUrl: 'appMain/appMain.template.html',
    controller: MainController
})


