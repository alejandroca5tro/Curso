function calculadora (a,b,o) {
    if (o='s') {
        return (+a+b);
    } else if (o='r') {
        return (a-b);
    } else if (o='m') {
        return (a*b);
    } else (o='d') {
        return (a/b);
    }
}

let nA = Number(prompt('Dime un número', 5));
let nB = Number(prompt('Dime otro', 10));
let sO = String(prompt('¿Qué quieres hacer? "s" para suma, "r" para resta, "m" para multiplicar o "d" para dividir', 's'));
let nR = calculadora (nA, nB, sO);
console.log(nR);