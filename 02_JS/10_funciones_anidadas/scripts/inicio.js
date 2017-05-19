(function main () {
    let nNum1 = 0;
    let nNum2 = 0;
    let sumar = (a,b) => {
        return +a + +b;
    }
    let restar = (a,b) => {
        return +a + +b;
    }
    function sumaDobles = (a, b) => {
        a *= 2; // a = 2*a
        b *= 2;
        return a + b;
    }
    nNum1 = Number(prompt('Dime un número', 12));
    nNum2 = Number(prompt('Dime otro', 12));
    let nResultSumaDobles = sumaDobles (nNum1, nNum2);
    let nResultSuma = sumar (nNum1, nNum2);
    let nResultResta = sumar (nNum1, nNum2);
    console.log(nResultSuma);
    console.log(nResultResta);
    console.log(nResultSumaDobles);
})();