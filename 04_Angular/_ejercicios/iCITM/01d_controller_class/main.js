// Ejemplo del controller NO utilizando inyección del $scope,
// sino la forma controller ... as en la directiva
// junto con la definición de clase propia de ES6/2015
// tal como recomienta la guía de estilo de AngularJS (ES2015) de Todd Motto


 class MainController {

    //constructor () {
    //}

    $onInit () {
        this.nombre = 'Pepe'; 
        this.nuevoPensamiento = ''; // declaracion innecesaria pero recomendable
        this.aPensamientos = [];
    }

    botonAdd () {
        this.aPensamientos.push(this.nuevoPensamiento); 
        this.nuevoPensamiento = '';
    }   
} // Fin de la clase


angular.module("miApp", [])
.controller("MainController", MainController ); // fin de MainController





