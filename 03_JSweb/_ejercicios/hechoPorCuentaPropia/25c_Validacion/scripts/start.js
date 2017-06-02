function main() { //envio de evento a la funcion manejadora.

    function comprobacion_5(oEvent) {
        oEvent.preventDefault();
        domInputFecha = oEvent.currentTarget.children[0];
        domRespuesta = document.getElementById('parrafo_5');
        // reformateamos la fecha estilo "español"
        var aFecha = domInputFecha.value.split('-').reverse();
        var txtFullFecha = aFecha.join("/");
        // guardaríamos com date para posible usus posteriores
        var date = new Date(aFecha[2], aFecha[1] - 1, aFecha[0]); //año,mes,dia
        muestraAcierto(txtFullFecha, date.getDay());
    }

    function comprobacion(oEvent) {
        domInputFecha = oEvent.currentTarget.previousElementSibling;
        domRespuesta = document.getElementById('parrafo');
        var RegEx_texto = /^\d{1,2}\/\d{1,2}\/\d{2,4}$/;
        var txtFullFecha = document.getElementById('txtFecha').value;
        if (txtFullFecha.search(RegEx_texto) < 0) {
            return muestraAviso(0);
        };
        var aFecha = txtFullFecha.split('/')
        var date = new Date(aFecha[2], aFecha[1] - 1, aFecha[0]); //año,mes,dia
        var date_mes = date.getMonth();

        if (date_mes + 1 != aFecha[1]) {
            muestraAviso(1);
        } else {
            domInputFecha.classList.remove("invalid");
            domInputFecha.classList.add("required");
            txtFullFecha = aFecha[0] + "/" + aFecha[1] + "/" + date.getFullYear();
            muestraAcierto(txtFullFecha, date.getDay());
        }
        return false;
    }

    function muestraAviso(n) {
        var aMensajes = ["El formato de la fecha no es valido",
            "La fecha no es valida"
        ];
        domInputFecha.classList.add("invalid");
        domRespuesta.classList.add("emergente");
        domRespuesta.innerHTML = aMensajes[n];
        setTimeout(function() {
            domRespuesta.classList.remove("emergente");
            domRespuesta.innerHTML = ""
        }, 2000)

        return false;
    }

    function muestraAcierto(txtFecha, diaSemana) {
        domRespuesta.innerHTML = 'El día ' + txtFecha + ' cae en ' + aDias[diaSemana];
    }

    var aDias = ["Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado"]
        // accesos al dom que variaran según se use la primera o la segunda parte del formulario
    var domInputFecha, domRespuesta;

    // manejador para el formulario al usar HTML5
    document.getElementById('formulario_5').addEventListener("submit", comprobacion_5)
        // manejador para el botos de HTML - clásico
        //  que no es de tipo submit
    document.getElementById('boton').onclick = comprobacion;

    domInputFecha = document.getElementById("txtFecha").classList.add("invalid")

}; //fin del onload

window.onload = main;