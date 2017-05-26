//Declaración de una función como variable
//let n_var = "valor variable"
let sumar = function (a,b) {return +a + +b}

//Declaración de una función arrow. Una nueva forma de escribir funciones en ES6 en la que se quita la palabra function y se pone "un arrow". El uso de la expresión dis es más consistente que en las funciones normales.

let restar = (a,b) => {return +a + +b}

//Declaración de una función
function sumaDobles (a, b) {
    a *= 2; // a = 2*a
    b *= 2;
    return a + b;
}

function main () {
    let nNum1 = 0
    let nNum2 = 0

    nNum1 = Number(prompt('Dime un número', 12));
    nNum2 = Number(prompt('Dime otro', 12));

    let nResultSumaDobles = sumarDobles (nNum1, nNum2)
    let nResultSuma = sumar (nNum1, nNum2)
    let nResultResta = sumar (nNum1, nNum2)

    console.log(nResultSuma);
    console.log(nResultResta);
    console.log(nResultSumaDobles)
}

//Invocación de la función
main();