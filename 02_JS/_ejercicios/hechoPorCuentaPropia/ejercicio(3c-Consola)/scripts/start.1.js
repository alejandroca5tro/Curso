var stock = 2500;
var precio = 26;

var n1 = String(precio > 20 && precio < 30);
document.write(n1 + '<br>');
console.log(n1);

n1 = String(precio > 20 && precio < 25);
document.write(n1 + '<br>');
console.log(n1);

n1 = String(stock == 2000 || stock == 2500);
document.write(n1 + '<br>');
console.log(n1);

n1 = String(stock != Number(2000) || stock != 2500);
document.write(n1 + '<br>');
console.log(n1);

n1 = String(stock >= 2000 && stock <= 2500 || precio > 25);
document.write(n1 + '<br>');
console.log(n1);