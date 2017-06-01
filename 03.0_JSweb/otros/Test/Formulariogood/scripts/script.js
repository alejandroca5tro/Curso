class Formulario {
    constructor() {
        this.fForm = document.querySelector("#formBlue"),
            this.fNombre = document.querySelector("#name"),
            this.fPApellido = document.querySelector("#sname"),
            this.fSApellido = document.querySelector("#s2name"),
            this.fFechaNacimiento = document.querySelector("#date"),
            this.fEmail = document.querySelector("#email"),
            this.fContrasena = document.querySelector("#pass"),
            this.fRContrasena = document.querySelector("#rpass"),
            this.aCBox = document.querySelectorAll("[name = aficion]"),
            this.fParrafo = document.querySelector("#start"),
            this.rButt = document.querySelectorAll("[name = category]"),
            this.fSalida = [],
            this.sSelect = "",
            this.aPasswd = ["", ""],
            this.domSubCurso = document.querySelector("#sCurso"),
            this.cCurso = {
                web: ["HTML", "Css", "JS", "PHP"],
                sist: ["aaaaa", "bbbbb", "ccccc", "ddddd"],
                obj: ["11111", "22222", "33333", "44444"]
            }


    }

    sacarTextos() {
        this.fSalida = [
            { etiqueta: "Nombre", valor: this.fNombre.value },
            { etiqueta: "Primer Apellido", valor: this.fPApellido.value },
            { etiqueta: "Segundo Apellido", valor: this.fSApellido.value },
            { etiqueta: "Fecha de nacimiento", valor: this.fFechaNacimiento.value },
            { etiqueta: "Correo Electronico", valor: this.fEmail.value },
            { etiqueta: "Contraseña", valor: this.fContrasena.value },

        ]


    }


    diaHoy() {
        let hoy = new Date();
        let dias = ["Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"];
        let meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];
        document.getElementById("systemDate").innerHTML = "Hoy es " + " " + dias[hoy.getDay()] + " " + "dia" + " " + hoy.getDate() + " " + "de" + " " + meses[hoy.getMonth()] + " " + "del año" + " " + hoy.getFullYear();
    }
    chBox() {
        let aficiones = ""
        for (let i = 0; i < this.aCBox.length; i++) {
            if (this.aCBox[i].checked) {
                aficiones = aficiones + " " + this.aCBox[i].value + " ,";
            }

        }
        this.fSalida[this.fSalida.length] = { etiqueta: "Aficiones", valor: aficiones.slice(0, -1) }

    }
    doIt(the_value) {
        switch (the_value) {
            case "web":
                this.cargarSelect(this.domSubCurso, this.cCurso.web)
                this.fSalida[this.fSalida.length] = { etiqueta: "Programador web", valor: this.sSelect }
                break;

            case "sist":
                this.cargarSelect(this.domSubCurso, this.cCurso.sist)
                this.fSalida[this.fSalida.length] = { etiqueta: "Programador de sistemas", valor: this.sSelect }
                break;

            case "obj":

                this.cargarSelect(this.domSubCurso, this.cCurso.obj)
                this.fSalida[this.fSalida.length] = { etiqueta: "Programador de objetos", valor: this.sSelect }
                break;


        }
    }

    cargarSelect(oDom, aDatos) {
        oDom.innerHTML = "";
        for (var i = 0; i < aDatos.length; i++) {
            oDom.innerHTML += "<option>" + aDatos[i] + "</option>";
        }
    }
    escribeSelect() {
   
       let nSelect = this.domSubCurso.options[this.domSubCurso.selectedIndex];
        this.sSelect = nSelect.text;
        let selValor = nSelect.value;
        
      



    }
    fRecDatos() {



        this.sacarTextos();
        this.chBox();
        this.escribirTextos();
        this.escribeSelect();




        //oE.preventDefault();

    }
    escribirTextos() {
        document.querySelector("#formBlue").className = "oculto";
        document.querySelector("#respuesta").className = "bloque";
        for (var i = 0; i < this.fSalida.length; i++) {
            this.fParrafo.innerHTML += `<li> ${this.fSalida[i].etiqueta} : </strong> ${this.fSalida[i].valor}</li> `
        }
    }

}



document.addEventListener("DOMContentLoaded", function () {
    oFormulario = new Formulario;


    document.getElementById("submit").onclick = oFormulario.fRecDatos.bind(oFormulario);

    oFormulario.diaHoy();
}, false);
