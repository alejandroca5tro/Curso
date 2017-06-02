function loadDoc() {


    var file = new XMLHttpRequest();
    file.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("contenidos").innerHTML = this.responseText;
        }
    };

    file.open('GET', 'http://localhost:7080/Curso/04_Angular/_ejercicios/vistoEnClase/21_repaso_ajax/ejemplo01/data/1/fichero_1.txt', true);
    file.send();
}





// class Formulario {

// }



// var _getAllFilesFromFolder = function(dir) {

//     var filesystem = require("fs");
//     var results = [];

//     filesystem.readdirSync(dir).forEach(function(file) {

//         file = dir + '/' + file;
//         var stat = filesystem.statSync(file);

//         if (stat && stat.isDirectory()) {
//             results = results.concat(_getAllFilesFromFolder(file))
//         } else results.push(file);

//     });

//     return results;

// };

// _getAllFilesFromFolder();



// xhttp.open("GET", "http://localhost:7080/Curso/04_Angular/_ejercicios/vistoEnClase/21_repaso_ajax/ejemplo01/data/1/fichero_1.txt", true);
// xhttp.send();


// function loadXMLDoc() {
//     var xhttp = new XMLHttpRequest();
//     xhttp.onreadystatechange = function() {
//         if (this.readyState == 4 && this.status == 200) {
//             document.getElementById("demo").innerHTML =
//                 this.responseText;
//         }
//     };
//     xhttp.open("GET", "xmlhttp_info.txt", true);
//     xhttp.send();
// }