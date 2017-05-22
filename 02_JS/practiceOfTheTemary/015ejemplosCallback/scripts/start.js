//Comprobaciones y pruebas

function one() { return 1; }

function two() { return 2; }

function invoke_and_add(a, b) {
    return a() + b(); //error de indefinición
}

invoke_and_add(one, two);

invoke_and_add(function() { return 1; }, function() { return 2; })


var n1 = one();
var n2 = two();
var n3 = invoke_and_add();
var n4 = invoke_and_add(one, two);
var n5 = invoke_and_add(1, 2);

console.log(n1);
console.log(n2);
console.log(n3);
console.log(n4);
console.log(n5);