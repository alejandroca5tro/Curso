//Definición de los parámetros de entrada y salida

var n1 = prompt('Introduce un valor para la variable n1', '10');
var n2 = prompt('Introduce un valor para la variable n2', '20');
var resAddF1;
var resAddF2;
var objeto = { var_1: 12, var_2: 5, resultado: 0 };

//Definición de las funciones

function addF1() { //función 1
    resAddF1 = Number(n1) + Number(n2);
}

function addF2(fP1, fP2) { //función 2
    resAddF2 = Number(fP1) + Number(fP2);
}

function addF3(fP1, fP2) { //función 3
    let fR = Number(fP1) + Number(fP2);
    return fR;
}
/*
function sumAndStore(obj) { //función 4
    obj[2] = obj[0] + obj[1];
}
*/
function sumAndStore(obj) { //función 4
    obj.resultado = obj.var_1 + obj.var_2;
}

//Ejecución de las funciones

addF1();

addF2(n1, n2);

var resAddF3 = addF3(n1, n2);

sumAndStore(objeto);

//Mostrar resultados por consola

console.log('Resultado de la función 1: ' + resAddF1);
console.log('Resultado de la función 2: ' + resAddF2);
console.log('Resultado de la función 3: ' + resAddF3);
console.log('Resultado de la función 4: ' + objeto.resultado);