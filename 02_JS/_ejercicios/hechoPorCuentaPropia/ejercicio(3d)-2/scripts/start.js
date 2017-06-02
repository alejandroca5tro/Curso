var vars = [true, false, 'hola', 'adios', 5, 2];

var e1 = ((vars[2] > vars[3]) ? vars[2] : vars[3]);
document.write(e1 + '<br>');
console.log(e1);

var e2_1 = (vars[0] != vars[1]);
document.write(e2_1 + '<br>');
console.log(e2_1);

var e2_2 = (vars[0] == vars[1]);
document.write(e2_1 + '<br>');
console.log(e2_1);

var e3_add = (Number(vars[4]) + Number(vars[5]));
document.write(e3_add + '<br>');
console.log(e3_add);

var e3_sub = (Number(vars[4]) - Number(vars[5]));
document.write(e3_sub + '<br>');
console.log(e3_sub);

var e3_pro = (Number(vars[4]) * Number(vars[5]));
document.write(e3_pro + '<br>');
console.log(e3_pro);

var e3_div = (Number(vars[4]) / Number(vars[5]));
document.write(e3_div + '<br>');
console.log(e3_div);

var e3_rem = (Number(vars[4]) % Number(vars[5]));
document.write(e3_rem + '<br>');
console.log(e3_rem);