class Form {

    constructor() {

        //Defino el nodo del DOM al formulario completo
        this.courseForm = document.querySelector("#courseForm")

        //Defino un objeto para todos los datos a presentar
        this.dataCollected = [
            { dataName: 'Nombre', content: '' },
            { dataName: 'Primer apellido', content: '' },
            { dataName: 'Segundo apellido', content: '' },
            { dataName: 'Fecha de nacimiento', content: '' },
            { dataName: 'Curso elegido', content: '' },
            { dataName: 'Asignatura elegida', content: '' },
            { dataName: 'Aficiones', content: '' },
            { dataName: 'Correo electrónico', content: '' },
            { dataName: 'Contraseña', content: '' },
            { dataName: 'Fecha de registro', content: '' }
        ];

        //Defino el nodo del DOM al botón submit
        this.submitButton = document.querySelector("#submitButton");

        //Recoleto los datos una vez se haga click en el botón submit
        this.submitButton.addEventListener("click", this.dataCollector.bind(this));

        //Defino el nodo del DOM al div donde se van a presentar los datos
        this.outputData = document.querySelector("#dataSent");

        //Simulo el envío de los datos
        this.courseForm.addEventListener("submit", this.shippingSimulation.bind(this));
    }

    dataCollector(event) {
        this.dataCollected[0].content = document.querySelector('fieldset#personalData input[name="name"]').value;
        this.dataCollected[1].content = document.querySelector('fieldset#personalData input[name="firstFamilyName"]').value;
        this.dataCollected[2].content = document.querySelector('fieldset#personalData input[name="secondFamilyName"]').value;
        this.dataCollected[3].content = document.querySelector('fieldset#personalData input[name="birthDate"]').value;
        this.dataCollected[4].content = courseForDC;
        this.dataCollected[5].content = document.querySelector('select#subjectSelection > option').value;
        this.dataCollected[6].content = hobbiesForDC;
        this.dataCollected[7].content = document.querySelector('fieldset#identification input[name="email"]').value;
        this.dataCollected[8].content = document.querySelector('fieldset#identification input[name="password2"]').value;
        this.dataCollected[9].content = document.querySelector('fieldset#date p#nowis span.dateFigures').textContent;
    }

    shippingSimulation(event) {

        //Evito el comportamiento por defecto, lo cual no me permitiría mostrar la presentación de los datos
        event.preventDefault();

        // Preparo los datos para su presentación
        var output = '';
        for (let index = 0; index < this.dataCollected.length; index++) {
            output += '<span class="dataName">' + this.dataCollected[index].dataName + ': </span><span>' + this.dataCollected[index].content + '<br>';
        }

        //Presento los datos
        document.querySelector('section.form').className = 'hidden';
        document.querySelector('section.outputDataPresentation').className = 'onscreen';
        this.outputData.innerHTML = output;
    }
}

identification();

//Defino una variable global para guardar posteriormente el curso seleccionado y utilizarla en el recolector de datos del constructor.
var courseForDC = '';

course();

date();

//Defino una variable global para guardar posteriormente los hobbies seleccionados y utilizarla en el recolector de datos del constructor.
var hobbiesForDC = '';

hobbies();

function identification() {

    password();

    function password() {

        //Defino un objeto los nodos del DOM para los input con contraseña
        var domPassword1 = document.getElementById('password1')
        var domPassword2 = document.getElementById('password2')

        //Defino un patrón de validación (muy sencillo, para qué más) y un texto a incluir en el mensaje
        domPassword1.pattern = '.{4,}';
        domPassword1.title = 'Se solicita un mínimo de 4 carácteres';

        //Compruebo si las contraseñas son iguales cuando se escriba algo en el campo "Repita su clave de acceso"
        domPassword2.oninput = checkPasswords;

        //Función para comprobar las contraseñas
        function checkPasswords() {
            let popMessage = "";
            if (domPassword1.value != domPassword2.value) {
                popMessage = "Las contraseñas no coinciden";
            }
            domPassword2.setCustomValidity(popMessage);
        }
    }
}

function course() {

    //Defino un objeto que contiene todos los cursos y sus correspondientes asignaturas (se que esto es complicarlo bastante, pero me gusta más la idea de cargarlo desde JavaScript)
    var Courses = [
        { name: 'Programador Web', subjects: ['Html', 'CSS', 'JavaScript', 'PHP'] },
        { name: 'Programador de Sistemas', subjects: ['Java', 'VBScript', 'Eclipse', 'SQL Server'] },
        { name: 'Programador de Objetos', subjects: ['Python', 'MongoDB', 'Ruby', 'VB.NET'] }
    ];

    //Defino los nodos del DOM para la selección de cursos y asignaturas
    var domCourseSelection = document.querySelector('#courseSelection');
    var domSubjectSelection = document.querySelector('#subjectSelection');

    //Cargo los cursos en el navegador, desde el objeto Courses 
    loadCourses(domCourseSelection, Courses);

    //Creo los nodos a los cursos que acabo de cargar, para poder trabajar con ellos (aquí está la clave del asunto y lo más complicado, pero admitamos que es bastante guay)
    bindRadioEvents();

    //Función para cargar los cursos desde el objeto Courses
    function loadCourses(oDom, aElements) {
        let output = '';
        for (let index = 0; index < aElements.length; index++) {
            output += '<input type="radio" name="course" id="course' + index + '" value="' + index + '" required/> <label for="course' + index + '">' + aElements[index].name + '</label><br>';
        }
        oDom.innerHTML = output;
    }

    //Función para enlazar los cursos cargados, creando los nodos y detectando cambios internos en los radioButtons creados
    function bindRadioEvents() {
        let radioButtons = document.querySelectorAll('#courseSelection > input[type="radio"]');

        for (let index = 0; index < radioButtons.length; index++) {

            let radio = radioButtons[index];
            radio.addEventListener('change', handleRadioChange);
            //Esta parte es importante: cuando en el sujeto (radio) se produzca el evento (change) se ejecutará la función manejadora (handleRadioChange) de dicho evento (cambio) 
        }
    }

    //Función manejadora del evento change sobre el sujeto radio
    function handleRadioChange(event) {
        let index = event.target.getAttribute('value');
        //event.target es el nodo del DOM donde se ha producido el evento (el radio button).
        let subjects = Courses[index].subjects;
        loadSubjects(domSubjectSelection, subjects);
        //Guardo el curso obtenido en una variable global para utilizarlo en el recolector de datos del constructor.
        courseForDC = Courses[index].name;
    }

    //Función para cargar las asignaturas de cada curso
    function loadSubjects(oDom, aElements) {
        let output = '';
        for (let index = 0; index < aElements.length; index++) {
            output += '<option>' + aElements[index] + '</option>';
        }
        oDom.innerHTML = output;
    }
}

function date() {
    var now = new Date();
    document.getElementById('nowis').innerHTML = '<span>Fecha actual: </span><span class="dateFigures">' + now.getDate() + '/' + (now.getMonth() + 1) + '/' + now.getFullYear() + '</span>';

    //  + ' | ' + now.getHours() + ':' + now.getMinutes() + '</span>';
}

function hobbies() {
    let hobbies = document.querySelectorAll('fieldset#hobbies input[type="checkbox"]');
    for (let index = 0; index < hobbies.length; index++) {
        let hobby = hobbies[index];
        hobby.addEventListener('change', handleCheckboxChange);
    }

    function handleCheckboxChange(event) {
        let hobby = event.target.getAttribute('value');
        hobbiesForDC += hobby + ', ';
    }
}

class App {
    static main() {
        document.addEventListener("DOMContentLoaded", function() { new Form() }, false);
    }
}

App.main()