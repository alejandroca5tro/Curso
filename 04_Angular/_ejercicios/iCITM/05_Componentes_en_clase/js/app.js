// Tercera aproximación al formato "1.5"
// Se define el controller como una clase

class MainController {

    constructor () {
    }

    $onInit () {   
        this.texto = "Yo he visto cosas que vosotros no creeríais. Atacar naves en llamas más allá de Orión. He visto Rayos-C brillar en la oscuridad cerca de la puerta de Tannhäuser. Todos esos momentos se perderán en el tiempo... como lágrimas en la lluvia. Es hora de morir."

   }

} // Fin de la clase MainController

angular.module('appPrueba',[])
.controller('MainController', MainController)

