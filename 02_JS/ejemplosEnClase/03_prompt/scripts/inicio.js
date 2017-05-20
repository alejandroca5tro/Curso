 //var sNombre = prompt("Dime tu nombre", "John"); Esto es declarar una variable e inicializarla al mismo tiempo. Los dos paréntesis se llaman operador de ejecución, para ejecutar una función. Prompt solo lo usan los programadores para probar cosas, jamás se utiliza fuera del entorno de producción.

var sNombre, sApellido;

sNombre = prompt("Dime tu nombre", "John");
sApellido = prompt("Dime tu apellido", "John");

console.log("Hola " + sNombre + " " + sApellido); //Las salidas por consola no detienen la ejecución del programa. Los alert si, hasta que hace click en aceptar en la ventana que aparece. Poddemos hacer todo esto mediante node, en la consola de windows, mediante el comando (node inicio.js), de forma que no es necesario usar ningún html. Se puede practicar en node en cmd.