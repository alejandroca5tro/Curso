//Declaración de una función. Es siempre: te voy a dar estos valores y hagas esto esto y esto

function saluda () {
    let sSaludo = 'Hola'; //Esto son variables locales. Las funciones me aislan las variables del entorno de fuera.
    console.log(sSaludo);
}
function sumaDosNumeros (a, b) {
    return Number(a)+Number(b); //Importante la mayúscula en Number.
}
function restaDosNumeros (a, b) {
    return Number(a)-Number(b); //Importante la mayúscula en Number.
}
function multiplicaDosNumeros (a, b) {
    return Number(a)*Number(b); //Importante la mayúscula en Number.
}
function divideDosNumeros (a, b) {
    return Number(a)/Number(b); //Importante la mayúscula en Number.
}
function main () {
    let nNum1 = prompt('Dime un número', 12); 
    let nNum2 = prompt('Dime otro', 23);    
    saluda();
    console.log(sumaDosNumeros (nNum1, nNum2));
    console.log(restaDosNumeros (nNum1, nNum2));
    console.log(restaDosNumeros (nNum2, nNum1));
    console.log(multiplicaDosNumeros (nNum1, nNum2));
    console.log(divideDosNumeros (nNum1, nNum2));
    
    //A esto se le llama encapsulación del código, las variables no están fuera de la función. Tiene la ventaja de poder guardar el contenido de una función en un fichero aparte. No hay que preocuparse de que no haya variables definidas globalmente, ya que están definidas dentro de cada función.
}

//Invocación. Es llamar a la función para que se ejecute. Los paréntesis se conocen como el operador de invocación. Sin ellos no hay invocación. Las funciones pueden ponerse en cualquier orden porque javascript hace "levantamiento de las funciones".

main();