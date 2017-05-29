// var fibo = [0, 1],
//     max = 100,
//     ind = 1,
//     next;
// do {
//     ind++;
//     next = fibo[ind - 2] + fibo[ind - 1];
//     if (next <= max) {
//         console.log(next);
//         fibo[ind] = next;
//     }
// } while (next < max);



function serieFibonacci(nMax) {
    var i = 0,
        j = 1;
    nMax = parseInt(nMax);
    // document.write("<p><b>Serie de Fibbonacci</b> hasta un máximo de " + nMax + "</p><ul>");
    document.write("<li>" + i + "</li>");
    document.write("<li>" + j + "</li>");
    do {
        j = j + i;
        i = j - i; // Recuperamos el anterior valor de j
        document.write("<li>" + j + "</li>");
    } while ((j + i) <= nMax);
    document.write("</ul>");
}