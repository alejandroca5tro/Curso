var num1 = prompt('Vamos a realizar algunos cálculos con dos números.\nEscribe el primero:', '45');
var num2 = prompt('Escribe el segundo número:', '60');

var start = 'El valor de ';

var sentVal1 = start + 'n1 es: ' + num1 + '<br>';
var sentVal2 = start + 'n2 es: ' + num2 + '<br>';
var sentAdd = start + 'varSuma es: ' + addSubProDiv(num1, num2)[0] + '<br>';
var sentSub = start + 'varResta es: ' + addSubProDiv(num1, num2)[1] + '<br>';
var sentPro = start + 'varProducto es: ' + addSubProDiv(num1, num2)[2] + '<br>';
var sentDiv = start + 'varDivision es: ' + addSubProDiv(num1, num2)[3] + '<br>';
var sentKTM = start + 'n1 en millas aprox es: ' + convertsKilometersToMiles(num1) + '<br>';
var sentFTC = start + 'n1 en º Fahrenheit en º Celsius es: ' + convertsFahrenheitToCelsius(num1) + '<br>';

var values = sentVal1 + sentVal2;
var calculations = sentAdd + sentSub + sentPro + sentDiv + sentKTM + sentFTC;

function addSubProDiv(n1, n2) {
    let resAdd = Number(n1) + Number(n2);
    let resSub = n1 - n2;
    let resPro = n1 * n2;
    let resDiv = n1 / n2;
    return [resAdd, resSub, resPro, resDiv];
}

function convertsKilometersToMiles(km) {
    let miles = Math.trunc(km * (1 / 1.60934));
    return miles;
}

function convertsFahrenheitToCelsius(Fah) {
    let Cel = Math.trunc(Fah * (1 / 32));
    return Cel;
}

function writeOnScreen(what) {
    document.write(what);
}