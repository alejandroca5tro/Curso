var cTexto1 = "valor inicial";
var cTexto2 = "valor inicial";


function unaFuncion() {
    var cTexto1
    cTexto1 = "Cambio desde dentro";
    cTexto2 = "Cambio desde dentro";
}

unaFuncion();
console.log(cTexto1) // devuelve "valor inicial"
console.log(cTexto2) // devuelve "Cambio desde dentro"