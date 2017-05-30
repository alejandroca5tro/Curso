class MainController {

     constructor($scope) {
        this.$scope = $scope;
    }

    $onInit () {
        this.oDatos = {texto : "Texto desde papa"}
        this.btn1 = "Enviar";
        this.btn2 = "Borrar"

//      this.$scope.$on("PRESS_BT", this.botones.bind(this))

        this.$scope.$on("PRESS_BT", (oEv, nBtn) => {
            switch (nBtn) {
                    case 1:
                        this.botonEnviar();
                        break;       
                    case 2:
                        this.botonBorrar();
                        break;
                }
        })       
    }


   botonEnviar() {
        alert ("Boton 1");
    }

   botonBorrar() {
       alert ("Boton 2");
    }

}

angular.module('appPrueba', ['appMain'])
.component("appStart", {
    templateUrl : 'main/main.template.html',
    controller : MainController,
})

