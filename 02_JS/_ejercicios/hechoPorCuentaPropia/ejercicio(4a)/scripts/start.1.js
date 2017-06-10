function wOS(whatEver) {
    document.write(whatEver);
}

function simpleOperations(n1, n2) {
    return [n1 + n2, n1 - n2, n1 * n2, n1 / n2]
}

function kmToMiles(km) {
    return Math.trunc(km / 1.60934);
}

function fToC(f) {
    return Math.trunc((f - 32) * (5 / 9));
}

var n1 = 60.5;
var n2 = 20;

wOS('El valor de n1 es ' + n1 + '<br>');
wOS('El valor de n2 es ' + n2 + '<br>');
wOS('<hr>');
wOS('El valor de varSuma es: ' + simpleOperations(n1, n2)[0] + '<br>');
wOS('El valor de varResta es: ' + simpleOperations(n1, n2)[1] + '<br>');
wOS('El valor de varProducto es: ' + simpleOperations(n1, n2)[2] + '<br>');
wOS('El valor de varDivisión es: ' + simpleOperations(n1, n2)[3] + '<br>');
wOS('El valor de n1 en millas aprox es: ' + kmToMiles(n1) + '<br>');
wOS('El valor de n1 Farenheit en Celsius es: ' + fToC(n1));