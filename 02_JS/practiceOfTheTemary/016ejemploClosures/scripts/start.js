/*
var enteroUnico = function() {
    var contador = 0;

    function contar() { return contador++; };
    return contar;
}();
*/

var enteroUnico = function() {
    var contador = 0;
    return function() { return contador++; };
}();

console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());
console.log(enteroUnico());