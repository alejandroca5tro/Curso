// for (var i = 0; i <= 100; i++) {

//     var notPrim = false;
//     for (var i = 2; i <= i; i++) {
//         if (i % i === 0 && i !== i) {
//             notPrim = true;
//         }
//     }
//     if (notPrim === false) {
//         console.log(i);
//     }
// }

/*
var prim = 0;

for (var i = 0; i < 100; i++) {
    prim++;
    var div = 0;
    var ind = 0;

    for (var j = 2; j < (prim); j++) {
        if ((prim % j) > 0) {
            ind++;
        }
    }

    if (ind = 0) {
        document.write(String(prim) + '<br>');
    }

}
*/




// Lista de primos menores que 100
// Código en un solo for

function main_1() {
    var numero, j, esPrimo;
    for (numero = 2; numero <= 100; numero++) {
        esPrimo = true;
        for (j = 2; j < numero; j++) {
            if (numero % j == 0) {
                esPrimo = false;
                break;
            }
        } // fin del for interno
        if (esPrimo) {
            document.write(numero);
            document.write('<br>');
        }
    } // fin del for externo
}

// Lista de primos menores que 100
// Código en dos funciones "independientes":


function main_2() {
    function esPrimo(numero) {
        esPri = true;
        for (var j = 2; j < numero; j++) {
            if (numero % j == 0) {
                esPri = false;
                break;
            }
        } // fin del for interno
        return esPri;
    }

    for (var numero = 2; numero <= 100; numero++) {
        if (esPrimo(numero)) {
            document.write(numero);
            document.write('<br>');
        }
    } // fin del for externo

}