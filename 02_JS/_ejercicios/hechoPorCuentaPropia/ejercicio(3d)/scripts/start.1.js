var var1 = true;
var var2 = false;
var var3 = 'hola';
var var4 = 'adios';
var var5 = 5;
var var6 = 2;

var ans = (var3 > var4);
console.log(ans);

ans = (String(var1) != String(var2));
console.log(ans);

ans = (String(var1) == String(var2));
console.log(ans);

var ans2 = 0;
ans2 = var5 + var6;
console.log(ans2);

ans2 = var5 - var6;
console.log(ans2);

ans2 = var5 * var6;
console.log(ans2);

ans2 = var5 / var6;
console.log(ans2);

ans2 = var5 % var6;
console.log(ans2);


var array1 = [var1, var2, var3, var4, var5, var6];

var ans = (array1[2] > array1[3]);
console.log(ans);

ans = (String(array1[0]) != String(array1[1]));
console.log(ans);

ans = (String(array1[0]) == String(array1[1]));
console.log(ans);

var ans2 = 0;
ans2 = Number(array1[4]) + Number(array1[5]);
console.log(ans2);

ans2 = Number(array1[4]) - Number(array1[5]);
console.log(ans2);

ans2 = Number(array1[4]) * Number(array1[5]);
console.log(ans2);

ans2 = Number(array1[4]) / Number(array1[5]);
console.log(ans2);

ans2 = Number(array1[4]) % Number(array1[5]);
console.log(ans2);