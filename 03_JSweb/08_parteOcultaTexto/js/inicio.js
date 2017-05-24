
window.onload = function () {

    let oBoton = document.querySelector("#btn1")
    let aParrafos = document.querySelectorAll(".dinamico")
    
    oBoton.innerHTML = "Ver más"
    oBoton.addEventListener("click", camviarVista)
    
    function camviarVista () {
        for (var i = 0; i < aParrafos.length ; i++) {        
            aParrafos[i].classList.toggle("oculto")
        }
        console.log(oBoton.innerHTML);
        
        oBoton.innerHTML = ("Ver más" ? "Ver menos" : "Ver más");
        
    }

}
