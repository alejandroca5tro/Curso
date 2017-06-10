var n1 = 60.5;
var n2 = 20;
var addR1;
var addR2;
var a1 = { var_1: 12, var_2: 5, resultado: 0 };

function add() {
    addR1 = n1 + n2;
}
add();
console.log(addR1);

function add2(n1, n2) {
    addR2 = n1 + n2;
}
add2(n1, n2);
console.log(addR2);

function add3(n1, n2) {
    return (n1 + n2);
}
console.log(add3(n1, n2));

function add4(obj) {
    obj.resultado = obj.var_1 + obj.var_2;
}
add4(a1);
console.log(a1.resultado);