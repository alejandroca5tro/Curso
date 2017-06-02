$(function() {

    aLista = [ < li > Esquí < /li> <
        li > Piragüismo < /li> <
        li > < a href = "https://es.wikipedia.org/wiki/Windsurf" > Tabla a vela < /a></li >
        <
        li > Natación < /li> <
        li > Gimnasia artística < /li> <
        li id = "lista1" > < a href = "https://runningyatletismo.com/atletismo/las-pruebas-lanzamiento-atletismo/" > Lanzamiento de atletismo < /a></li >
    ]

    $('#btn1').click(function() {
            let sItem = $('#item').val();
            $('#lista1').after('<li>' + )
        }


    )
    let oBoton = document.querySelector("#btn1")

    oBoton.addEventListener("click", addListElement)

    function addListElement() {
        $("li").after("<p>Hola, soy tu hermano</p>")
    }
})