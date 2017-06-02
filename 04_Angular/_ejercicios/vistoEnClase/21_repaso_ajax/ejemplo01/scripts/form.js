class Formulario {

    constructor() {
            this.aFiles = [
                "Fichero_1.txt",
                "Fichero_2.txt",
                "Fichero_3.txt",
                "Fichero_4.txt",
                "Fichero_5.txt"
            ]
            this.pintaFormulario();

        } // Fin del constructor

    pintaFormulario() {
        let oDomInput = document.querySelector('#ficherosDatalist');
        oDomInput.innerHTML = ""
        for (let i = 0; i < this.aFiles.length; i++) {
            let sFile = this.aFiles[i];
            oDomInput.innerHTML += `
				<option>${sFile}</option>`;
        };

        console.dir(oDomInput)
    }
}

window.onload = function() {
    //new App().controller()
    new Formulario()
}

$.Ajax({
    url: '',
    method: '',
})