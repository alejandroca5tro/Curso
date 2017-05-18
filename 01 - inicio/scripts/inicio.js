//JavaScrip & EcmaScript ES6. Son lo mismo. EcmaScript es una empresa de estandarización y no es la misma que afecta al html. ES6

//Lo ideal es empezar creando una función genérica que englobe todo y a partir de ahí ir desgranando.

/**
 * Constantes
 */

const SALUDO ='Hola ';
//Así es como debe hacerse, creando estos elementos para después poder modificarlos fácilmente, por ejemplo, si queremos hacer algo multilingüe, se podría referenciar a un registro.
//Las constantes se suelen poner en mayúsculas, no en camelcase.

/**
 * Variables
 * n indica una variable del tipo número
 * s indica una variable del tipo cadena (string)
 * booleanas (no necesita prefijo)
 */
//Esta formam de escribir las variables se llama notación húngara, se antepone una letra minúscula que tiene que ver con el tipo de variable. cosas como la notación húngara y el camelcase ayudan a clarificar el texto.

var nAlgo = 21;
var sCadena1 = 'John';
//Los números pueden introducirse tal cual, pero las cadenas deben ponerse entre comillas. Si no se pusieran comillas, entendería que es otra variable y la estamos igualando.
//Vamos a tener varias maneras de escribir variables:
var sCadena2 = "John";
//Todo tiene que ver con si queremos incluir comillas en el propio texto. Ejemplos:
var sCantaor1 = "Pepe 'El Lebrijano'";
var sCantaor2 = 'Juan "El Habichuela"';
//Se añaden las comillas opuestamante a las que queremos que se representen.
var sGrupo = sCantaor + " & " + sCantaor2;
//El resultado sería: Pepe 'El Lebrijano' & Juan "El Habichuela". Esto ofrece un mundo de posibilidades para el html.
//Otra forma es mediante comillas "francesas o chungas": ` (no son ') y eso sirve para interpolar variables. Eso significa que cuando aparece la variable, se introduce lo que vale lo variable, valga lo que valga en ese momento.
var sGrupo = `<ul>
                <li>${sCantaor1}</li>
                <li>${sCantaor2}</li>
            </ul>
        `
//Esto es la interpolación de variables y si queremos hacerlo de esta manera es necesario incluir este tipo de comillas  Con ES6 se pueden incluir retornos de carro. En general esto es propio de ES6.

/**
 * Significado de concatenar:d
 * dar signo positivo a algo
 * que se suman dos números
 * que se concatenan dos expresiones
*/

sCantaor1 = "";
//Esto cambiaría el valor de la variable.



var esBueno = TRUE;
var esMalo  = FALSE;
//Puede ponerse tanto en mayúsculas como en minúsculas. No tiene porqué empezar por es (en inglés suelen empezar por ¿is?¿its?)

var queSoy;
//es una variable que no tiene ningún tipo de valor. Vale undefined.
//Nunca se puede declarar dos veces una variable.

var $_az19
var _az19
// Formas de dar nombre a la variables: Cualquier combinación de:
/**
 * letras
 * números
 * _
 * $
*/
//El sistema es absolutamente sensible a minúsculas y mayúsculas.
// Puede empezar por $ o no pero no se suele llamar a algo $_az19, sino de alguna forma que nos recuerde a qué nos estamos refiriendo.
//Hay lenguajes, como el PHP, que las variables deben empezar por $, aunque en javascript no es necesario.



//Acceso al Node Btn1 del DOM.
var oBtn1 = document.querySelector('#btn1');
/*Esto es una variable. El ID del objeto se introduce entre comillas simples. También podrían ser dobles*/
//Existe una convención del lenguaje que se llama camel case. Por ejemplo Cómo te llamas sería comoTeLlamas. Este tipo de comentario no hay que cerrarlo.
//El punto y coma es opcional, pero es mejor ponerlo.
/**También pueden ponerse comentarios así
 * para que en cada línea ponga un asterisco
 * A esto se le llama javascript doc*/
//Acceso al Node nombre del DOM
var oNombre = document.querySelector('#nombre');
//Acceso al Node respuesta del DOM
var oEdad = document.querySelector('#edad');
var oRespuesta = document.querySelector('#respuesta');

//C, C++, JAVA. Ejemplo:
//Int iEdad = 22;
//Define valores enteros (integer). Si introdujésemos "pepe" daría un valor de error.
//Algunas definiciones
//Tipado: Hay que definir el tipo de variable que es
//Estático: las variables no pueden cambair de tipo
//javascript es un lenguaje muy débilmente tipado y no estático. Eso no implica que cojamos una sola variable para hacerlo todo. Es mejor hacer las variables más claras y por ello, la notación húngara es mejor, además de ser aconsejable definir una variable para cada valor.

var queSoy;
queSoy = esMalo;
nEdad = "John";
//Cuando se le cambia el tipo de contenido a una variable, automáticamente la variable cambia de tipo.

/**
 * Funciones
 */

/*
function saludar () {
    let sNombre = oNombre.value;
    //let es como var. Es crear una variable local para entender mejor cómo funciona.
    alert(SALUDO + sNombre);
    //Introducir aquí el "hola" se conoce como hardcodear, hemos introducido un hardcode en mitad de la función. Es mejor definirlo como constante.
}
*/

//Otra manera de añadir cosas:
function saludar () {
    let sSaludo = SALUDO;
    //let es la forma de definir una variable en ES6 y es una variable creada de forma local. En nuestro caso es lo mismo que var.
    let nEdad = oEdad.value;
    sSaludo += oNombre.value;
    oRespuesta.innerHTML = "<b>"+ sSaludo +"</b>";
    oRespuesta.innerHTML += sGrupo;
    oRespuesta.innerHTML += +nEdad+2; //Aquí, sin un símbolo + por delante del string, convierte el número en texto, no el texto en número. Por eso se mostrará 442. Cuando se junta un string con un number y se usa un +, se concatena, no se suma. Pero si al string se le añade un símbolo + por delante, se transforma el string en un número y si lo suma.
    //Cuando le añadimos esto... hacemos lo que se conoce como un doble ¿vainin? pasamos valores a javascript que también se ven en HTML.
    //con innerHTML podemos pasarle lo que queramos al HTML.
    /*
    alert( sSaludo);
    */
    //Si omitimos el alert, no aparecerá.
    //A esto se lo conoce como refactorización. El código ha cambiado, es más limpio y con otro estilo pero hace lo mismo.
    //El sistema es absolutamente sensible a minúsculas y mayúsculas. Si escribiésemos Value en lugar de value, no funcionaría. El camelCase nos ayuda a tener claro qué escribir con mayúsculas y qué con minúsculas.
    //El += se utiliza para que no se pise el valor anterior, sino que se sume.

}

oBtn1.onclick = saludar;
//El evento es onclick, ¿dónde? en el botón (oBtn1)

//oBtn1.onclic = alert('Hola');
//oBtn1.onclic = "alert('Hola')";
//Si lo ponemos sin comillas, se "disparará", hará su función. Si lo ponemos entre comillas, no lo hará.

console.dir(oBtn1);
//Si le ponemos comillas, saldría literalmente lo que le pusiéramos entre comillas
console.dir(oNombre);
console.dir(oRespuesta);
//Si queremos ver algo de lo que está haciendo, deberemos abrir la consola del browser (F12, console)
console.log(nEdad);

//Fundamental: tener la consola abierta y leer los errores.

// OPERADORES + - * / ^ para operaciones (^ es el resto)
//Division
var x = 13 / 3;
//Módulo o resto
var y = 13 ^ 3;