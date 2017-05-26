function main() {
    const Q1 = "Introduce un número entero",
        TEXT1 = "El número introducido es ",
        TEXT2 = "Eso no es un número",
        PAR = "<b>par</b>",
        IMPAR = "<b>impar</b>";

    function parImpar(numero) {
        if (isNaN(parseInt(numero))) {
            return -1; // No es un número
        } else {
            return (numero % 2);
            // 1 si Numero impar & 0 Numero par
        }
    } // Fin de la función parImpar

    function muestraDatos(codigo) {
        var cTexto;
        switch (codigo) {
            case 0:
                cTexto = TEXT1 + PAR;
                break;
            case 1:
                cTexto = TEXT1 + IMPAR;
                break;
            case -1:
                cTexto = TEXT2;
                break;
        }
        document.write(cTexto);
    } // Fin de la función 
    muestraDatos(parImpar(prompt(Q1)));
}

main();