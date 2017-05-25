$(function() {

    $('#btn1').click(function() {
            let sItem = $('#item').val();
            $('#lista1').after('<li>' + $('#item'))
        }


    )
    let oBoton = document.querySelector("#btn1")

    oBoton.addEventListener("click", addListElement)

    function addListElement() {
        $("li").after("<p>Hola, soy tu hermano</p>")
    }
})