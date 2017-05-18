var sName = "Funciones" //Esto es una variable global. var al nivel más alto posible. No habría que pasársela ya a nadie.

function main () {
    let sMainName = 'Funcion Main';
    //let nNum1 = Number(prompt('Dime un número', 10)); 
    //let nNum2 = Number(prompt('Dime otro', 20));
    //let nNum3 = +prompt('Dime otro', 10); //para qué es el +?
    //let nNum4 = +prompt('Dime otro', 20);

    if (2) {
        let sName = 'Condicional';
    }
    
    console.log(sName);  //Hasta ES6 no habría podido poner ahí el let, y el valor hubiera cambiado. Si pongo un var en lugar de un let no funcionaría, ya que no entendería que es un let dentro de una función.
}


main();

console.log(sMainName);

//Puedo tener muchas variables con el mismo nombre, mientras que tenga definidos los ámbitos concretos donde usan ese valor.