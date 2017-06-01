$('.answer').hide();
$('.questionBlock question').click(
    function() {
        if ($(this).attr('class') != 'close') {
            $(this).next('answer').slideDown();
            $(this).addClass('sepuedecerrar');
        } else {
            $(this).next('.answer').fadeOut();
            $(this).removeClass('sepuedecerrar');
        }
    });


function mostrar() {

}

function ocultar() {

}