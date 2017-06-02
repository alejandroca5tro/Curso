function form() {

    // var aGeneros = ["Ciencia Ficcion", "Ciberpunk", "Fantasía", "Terror", "Policiaca"];
    // var oAutores = {
    //     "Ciencia Ficcion": ["Isaac Asimov", "Robetr A. Heinlein", "Philip K. Dick", "Frank Herbert", "Orson Scott Card", "Arthir C. Clarke", "Jack Vance", "Poul Anderson", "Robert Silverberg", "Brian W. Aldiss"],
    //     "Ciberpunk": ["William Gibson", "Bruce Sterling", "Neal Stephenson", "George Alec Effinger"],
    //     "Fantasía": ["Robert E. Howard", "J.R.R. Tolkien", "Terry Pratchett", "George R.R. Martin", "Tim Powers", "Ursula K. Le Guin", "Michael Moorcock", "Fritz Leiber"],
    //     "Terror": ["J. Sheridan Le Fanu", "Bran Stoker", "M.R. James", "H.P. Lovecraft", "Stephen King"],
    //     "Policiaca": ["Georges Simenon", "Arthur Conan Doyle", "Maurice Leblanc", "Edgar Allan Poe", "Agatha Christie", "Erle Stanley Gardner"]
    // };

    var aCourses = ['Programador Web', 'Programador de Sistemas', 'Programador de Objetos'];
    var oSubjects = {
        'Programador Web': ['Html', 'CSS', 'JavaScript', 'PHP'],
        'Programador de Sistemas': ['PS1', 'PS2', 'PS3', 'PS4'],
        'Programador de Objetos': ['PO1', 'PO2', 'PO3', 'PO4']
    };

    // var sSelectedGenero;
    // var sSelectedAutor;

    var sChoosenCourse;
    var sChoosenSubject;

    // nodos del DOM
    // var domSelecGeneros = document.querySelector("#genero");
    // var domSelecAutores = document.querySelector("#autores");
    // var domBoton = document.querySelector('#boton');

    var domCourseSelection = document.querySelector('fieldset#course div#courseSelection');
    var domSubjectSelection = document.querySelector('#subjectSelection');

    //manejadores
    // domSelecGeneros.addEventListener("change", cambioGenero);
    // domSelecAutores.addEventListener("change", cambioAutores);
    // domBoton.addEventListener("click", enviar);

    domCourseSelection.addEventListener('change', courseChange);
    domSubjectSelection.addEventListener('change', subjectChange);

    // configuración inicial
    // domSelecAutores.disabled = true;

    //domBoton.disabled = true;
    // cargarSelect(domSelecGeneros, aGeneros);
    loadCourses(domCourseSelection, aCourses);



    // function enviar() {
    //     return confirm("Desaa solicitar los datos de " + sSelectedAutor);
    // }

    // function cambioAutores(oE) {
    //     var domSelect = oE.currentTarget;
    //     if (domSelect.childElementCount > oAutores[sSelectedGenero].length) {
    //         domSelect.removeChild(domSelect.children[0]);
    //     }
    //     var nSelect = domSelect.selectedIndex;
    //     var domOption = domSelect.options[nSelect]
    //     sSelectedAutor = domOption.text;
    //     domBoton.disabled = false;
    // }

    function subjectChange(oSubjects) {
        var domSelect = oSubjects.currentTarget;
        let sSelect = domSelect.selectedIndex;
        let domOption = domSelect.options[sSelect];
        sChoosenSubject = domOption.text;
    }

    // function cambioGenero(oE) {
    //     var domSelect = oE.currentTarget;
    //     if (domSelect.childElementCount > aGeneros.length) {
    //         domSelect.removeChild(domSelect.children[0]);
    //     }
    //     let nSelect = domSelect.selectedIndex;
    //     let domOption = domSelect.options[nSelect];
    //     sSelectedGenero = domOption.text;
    //     // las tres lineas en una 
    //     // sSelectedGenero domSelect.options[domSelect.selectedIndex].text;

    //     cargarSelect(domSelecAutores, oAutores[sSelectedGenero]);
    //     domSelecAutores.disabled = false;
    // }

    function courseChange(oCourses) {
        var domSelect = oCourses.currentTarget;
        let rSelect = domSelect.selectedIndex;
        let domOption = domSelect.options[rSelect];
        sChoosenCourse = domOption.text;

        loadSubjects(domSubjectSelection, oSubjects[sChoosenCourse]);
    }

    // function cargarSelect(oDom, aDatos) {
    //     oDom.innerHTML = "<option> </option>";
    //     domBoton.disabled = true;
    //     for (var i = 0; i < aDatos.length; i++) {
    //         oDom.innerHTML += "<option>" + aDatos[i] + "</option>";
    //     }
    // }



    function loadSubjects(oDom, aElements) {
        oDom.innerHTML = '<option> </option>';
        let Element;
        for (let Element = 0; Element < aElements.lenght; Element++) {
            oDom.innerHTML += '<option>' + aElements[Element] + '</option>';
        }
    }

    function loadCourses(oDom, aElements) {
        // oDom.innerHTML = '<option> </option>';
        for (let Element = 0; Element < aElements.lenght; Element++) {
            oDom.innerHTML += '<input type="radio" name="course" required>' + aElements[Element] + '<br>';
        }
    }

}

form();

// function choosenCourse() {
//     var sChoosenCourse = document.querySelector('#course input:nth-of-type(1)');
//     console.log(sChoosenCourse);
//     var sChoosenSubject;
//     // nodos del DOM
//     var domCourseSelection = document.querySelector("course");
//     var domSelecAutores = document.querySelector("subject");
// }