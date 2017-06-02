var mayusMinus = function() {
    let sString = prompt('Introduce la cadena');
    let aChar = [];
    let aCharMa = [];
    let aCharmi = [];
    console.log(sString.length);
    for (i = 0; i < sString.length; i++) {
        aChar[i] = sString.charAt(i);
    }
    console.log(aChar);
    console.log(aChar.length);
    for (i = 0; i < aChar.length; i++) {
        aCharMa[i] = aChar[i].toUpperCase;
    }
    for (i = 0; i < aChar.length; i++) {
        aCharmi[i] = aChar[i].toLowerCase;
    }
    let inMa = 0;
    let inmi = 0;
    var response;
    for (i = 0; i < aChar.length; i++) {
        if (aChar[i] != aCharMa[i]) {
            inMa++;
        } else if (Char[i] != aCharmi[i]) {
            inmi++;
        }
    }
    if (inMa == 0) {
        response = 'La cadena es sólo de mayúsculas';
    } else if (inmi == 0) {
        response = 'La cadena es sólo de mayúsculas';
    } else {
        response = 'La cadena es mixta';
    }
    document.write(response);
}