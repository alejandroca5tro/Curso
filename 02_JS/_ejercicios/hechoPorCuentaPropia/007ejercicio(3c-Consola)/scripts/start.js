var Stock = 2500;
var Precio = 26

var n1 = String(Precio > 20 && Precio < 30);
document.write(n1 + '<br>');
console.log(n1);

var n2 = String(Precio > 20 && Precio < 25);
document.write(n2 + '<br>');
console.log(n2);

var n3 = String(Stock == Number(2000) || Stock == Number(2500));
document.write(n3 + '<br>');
console.log(n3);

var n4 = String(Stock != Number(2000) || Stock != Number(2500));
document.write(n4 + '<br>');
console.log(n4);

var n5 = String(Stock >= Number(2000) || Stock >= Number(2500));
document.write(n5 + '<br>');
console.log(n5);