window.onload = function() {

    let sWholeText = document.getElementById("sourceText").innerHTML;
    let aUglyWholeText = sWholeText.split(" ");

    let sSeparatorWord = "Explicabo";

    let SeparatorWordPosition = aUglyWholeText.indexOf(sSeparatorWord, 0);

    let aUglyShownText = [];

    for (var i = 0; i < (SeparatorWordPosition + 1); i++) {
        aUglyShownText[i] = aUglyWholeText[i];
    }

    let sShownText = aUglyShownText.join(" ");

    document.querySelector(".shown").innerHTML = sShownText;


    let aUglyHiddenText = [];

    for (var i = (SeparatorWordPosition + 1); i < aUglyShownText.length; i++) {
        aUglyHiddenText[i] = aUglyWholeText[i];
    }

    let sHiddenText = aUglyHiddenText.join(" ");

    document.querySelector(".oculto").innerHTML = sHiddenText;


    // let aParrafos = document.querySelectorAll(".oculto")



    //     function camviarVista() {
    //         for (var i = 0; i < aParrafos.length; i++) {
    //             aParrafos[i].classList.toggle("oculto");
    //             aParrafos[i].innerHTML = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ullam autem dolores beatae id impedit nobis, pariatur quaerat architecto quos perspiciatis libero, ipsam fugiat quo. Dolor assumenda provident sed amet minus. Lorem ipsum dolor sit";
    //         }
    //         oBoton.innerHTML = oBoton.innerHTML == "Ver más" ? "Ver menos" : "Ver más";
    //     }
}