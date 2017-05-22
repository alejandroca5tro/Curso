function mayor() {
    var elMayor = arguments[0];
    for (var i = 1; i < arguments.length; i++) {
        if (arguments[i] > elMayor) {
            elMayor = arguments[i];
        }
    }
    return elMayor;
}

var variable1 = mayor(1, 3, 5, 8);
var variable2 = mayor(4, 6, 8, 1, 2, 3, 4, 5);

console.log(variable1 + '\n' + variable2);