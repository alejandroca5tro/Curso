function sumaObjetos (a, b) {
    a.valor *= 2; // a = 2*a
    b.valor *= 2;
    return a.valor+b.valor;
}

function sumaDobles (a, b) {
    a *= 2; // a = 2*a
    b *= 2;
    return a.valor+b.valor;
}

function main () {
    let oNum1 = {valor : 0}
    let oNum2 = {valor : 0}

    oNum1.valor = Number(prompt('Dime un número', 12));
    oNum2.valor = Number(prompt('Dime otro', 12));

    console.log(oNum1);
    console.log(oNum1);

    console.log(sumaObjetos(oNum1, oNum2));

    console.log(oNum1); //Vigilar si lo que estamos pasando es una copia o la referencia. No es lo mismo pasar por referencia que pasar por valor. Esto es lo más importante de las funciones, cómo se pasan unos y otros tipos de valores.
    console.log(oNum1);
}

//Invocación de la función
main();