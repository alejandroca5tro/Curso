var n = Number(prompt('Cuántos parámetros quieres calcular'));
var acum = 0;
var num;
var aver;

for (var i = 0; i < n; i++) {
    num = prompt('Escribe un número');
    acum += Number(num);

}
aver = (acum / n);
document.write('La toma de datos ha concluido<br>La media resultante de los números introducidos es: ' + aver);


/*
var ent;
var select;
var num;
var acum = 0;
var n = 1;
var aver = 0;

for (var i = 0; i < n; i++) {
    ent = prompt('Escribe un número\no escribe "fin" para finalizar la entrada de datos', '5');


    if (String(ent) != 'fin' && (isNaN(Number(ent)) = 'false')) {
        select = 1;
    } else if (isNaN(Number(ent))) {
        select = 0;
    } else {
        select = 2;
    }

    switch (select) {
        case 0:
            ent = prompt('No se ha introducido un número\nEscribe un número', '5');
            break;
        case 1:
            acum += Number(num);
            n++;
            break;
        case 2:
            aver = (acum / n);
            document.write('La toma de datos ha concluido<br>La media resultante de los números introducidos es: ' + aver);
            break;
    }
}
*/