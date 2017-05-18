//Declaración de una función. Es siempre: te voy a dar estos valores y hagas esto esto y esto

function saluda () {
    let sSaludo = 'Hola'; //Esto son variables locales. Las funciones me aislan las variables del entorno de fuera.
    console.log(sSaludo);
}

//function mediaArg (a=0, b=0, c=0, d=0) {  //=0 Es propio de ES6
//    return a+b+c+d;

function sumaArg () { //Arg saca un "pseudoarray". Nos permite meter números sin tener que definir cuántos. Guarda todos los parámetros que le lleguen.
    let nResult=0;
    for (var i = 0; i < arguments.length; i++) {
        nResult += arguments[i];
    }
    return nResult;
}

function main () {
    let nNum1 = Number(prompt('Dime un número', 10)); 
    let nNum2 = Number(prompt('Dime otro', 20));
    let nNum3 = +prompt('Dime otro', 10); //para qué es el +?
    let nNum4 = +prompt('Dime otro', 20);    
    
    console.log(mediaArg (nNum1, nNum2));
    console.log(mediaArg (nNum1, nNum2, nNum3));
    console.log(mediaArg (nNum1, nNum2, nNum3, nNum4));

    //La diferencia entre dir y log es que uno saca los elementos completos y la otra incompletos.

    saluda();

    //A esto se le llama encapsulación del código, las variables no están fuera de la función. Tiene la ventaja de poder guardar el contenido de una función en un fichero aparte. No hay que preocuparse de que no haya variables definidas globalmente, ya que están definidas dentro de cada función.
}

function mediaArg () {
    let nResult=0;
    let nMedia1=0;
    for (var i = 0; i < arguments.length; i++) {
        nMedia1 += arguments[i];
        nResult = (nMedia1/arguments.length);
    }
    return nResult;
}

/**
 * Otra forma
 *  
function mediaArg () {
    let nResult=0;
    for (var i = 0; i < arguments.length; i++) {
        nResult += arguments[i];
    }
    return nResult/arguments.length;
}

*/

//Invocación. Es llamar a la función para que se ejecute. Los paréntesis se conocen como el operador de invocación. Sin ellos no hay invocación. Las funciones pueden ponerse en cualquier orden porque javascript hace "levantamiento de las funciones".

main();