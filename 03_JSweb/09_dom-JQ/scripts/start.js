$(function() {
    //let js = document.querySelector("#primera")
    //let jq = $("#primera")
    //console.dir(js)
    //console.dir(jq)


    let js = document.querySelectorAll("section")
    let jq = $("section")
    console.dir(js)
    console.dir(jq)


    //$("section").hide()
    //$("section").append("<p>Hola</p>")
    //$("section").prepend("<p>Hola</p>")
    $("section").after("<section>Hola</section>")
    $("section").after("<section>Hola</section>")
})