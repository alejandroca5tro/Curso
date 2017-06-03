function form() {

    var aCourses = [
        { name: 'Programador Web', subjects: ['Html', 'CSS', 'JavaScript', 'PHP'] },
        { name: 'Programador de Sistemas', subjects: ['PS1', 'PS2', 'PS3', 'PS4'] },
        { name: 'Programador de Objetos', subjects: ['PO1', 'PO2', 'PO3', 'PO4'] }
    ];

    var domCourseSelection = document.querySelector('#courseSelection');
    var domSubjectSelection = document.querySelector('#subjectSelection');

    loadCourses(domCourseSelection, aCourses);

    bindRadioEvents();

    function bindRadioEvents() {
        let radioButtons = document.querySelectorAll('#courseSelection > input[type="radio"]');

        for (let index = 0; index < radioButtons.length; index++) {

            let radio = radioButtons[index];
            radio.addEventListener('change', handleRadioChange);
        }
    }


    function handleRadioChange(event) {
        let index = event.target.getAttribute('value');
        //e.target es el nodo del DOM donde se ha producido el evento (el radioButton)
        let subjects = aCourses[index].subjects;
        loadSubjects(domSubjectSelection, subjects);
    }

    function loadSubjects(oDom, aElements) {

        let output = '';
        for (let index = 0; index < aElements.length; index++) {
            output += '<option>' + aElements[index] + '</option>';
        }
        oDom.innerHTML = output;
    }

    function loadCourses(oDom, aElements) {
        // oDom.innerHTML = '<option> </option>';
        let output = "";
        for (let index = 0; index < aElements.length; index++) {
            output += '<input type="radio" name="course" id="course' + index + '" value="' + index + '" required/> <label for="course' + index + '">' + aElements[index].name + '</label><br>';
        }
        oDom.innerHTML = output;
    }
}

form();