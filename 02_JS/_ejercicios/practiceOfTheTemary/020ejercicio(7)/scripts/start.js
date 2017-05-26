for (var i = 0; i <= 100; i++) {

    var notPrim = false;
    for (var i = 2; i <= i; i++) {
        if (i % i === 0 && i !== i) {
            notPrim = true;
        }
    }
    if (notPrim === false) {
        console.log(i);
    }
}

/*
var prim = 0;

for (var i = 0; i < 100; i++) {
    prim++;
    var div = 0;
    var ind = 0;

    for (var j = 2; j < (prim); j++) {
        if ((prim % j) > 0) {
            ind++;
        }
    }

    if (ind = 0) {
        document.write(String(prim) + '<br>');
    }

}
*/