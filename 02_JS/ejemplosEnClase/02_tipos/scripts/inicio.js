// JavaScript & EcmaScript ES6

/**
 * Constantes
 */

const SALUDO ='Hola ';
//const SALUDO ='Hello ';

/**
 * Variables y tipos de datos
 */


// Number
var nEdad = 12; //Suele ponerse la primera letra de la variable con mayúscula.
// String
var sCantaor1 = "Pepe 'El Lebrijano'"
var sCantaor2 = 'Juan "El Habichuela"'
// Boolean
var esBueno = true;
var esMalo = false;
// Undefined Es un tipo real, no es solamente una forma de decir que no tiene valor. Es un tipo como los otros.
var queSoy; 
// Null (Object)
var oDatos = {}


// Object
var oDatos = {
  nombre: "John",
  apellido: "Doe",
  edad: 23,
  nacionalidad: "Inglaterra",
  esVaron : true,
  oDireccion : {
    calle: "",
    numero:"",
    poblacion: "",
    cp: "",
    pais: ""
  }
}//Es un conjunto de elementos de los distintos tipos posibles agrupados en una estructura. Es un almacén o dato complejo, es decir, pueden almacenarse varios datos. También puede contener otro object. Las comillas pueden ponerse tanto simples como dobles. Los puristas las ponen simples. El último no tiene que llevar coma. La Notación de tipo json

console.info("Valores");
console.dir(nEdad);
console.dir(sCantaor1);
console.dir(oDatos);


sCantaor1 = "";
oDatos.oDireccion.calle = "C/ del Pez";

console.info("Tipos");
console.dir(typeof nEdad); //typeof dice qué tipo de objeto es.
console.dir(typeof sCantaor1);
console.dir(typeof oDatos);
console.dir(typeof esBueno);
console.dir(typeof queSoy);


// OPERADORES + - * / ^ typeoff

//Division
var x = 13 / 3;
// MÃ³dulo o resto
var y = 13 ^ 3