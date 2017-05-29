function muestraTiempo() {
    var sec = 0;
    for (i = 0, i < 1000000, i++) {
        sec++;
        document.write(sec);
    }
}

muestraTiempo();


var id = setInterval(muestraTiempo, 1)