var n;
n = Number(prompt('Escribe un número', '5'));

if (isNaN(n)) {
    document.write('No se ha introducido un número');
} else if (n % 2 != 0) {
    document.write('Se trata de un número impar');
} else {
    document.write('Se trata de un número par');
}