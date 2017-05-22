var cUsuario = prompt('¿Cuál es el usuario?', 'John');
var cCurso = prompt('¿Cuál es curso?', 'Desarrollo de Aplicaciones con Tecnologías Web');
var nDia = prompt('¿Qué día es?', '22');
var nMes = prompt('¿Qué mes es?', '5');
var nTiempo = 45;

document.write(
    'Usuario: ' + cUsuario + '<br>' +
    'Curso: ' + cCurso + '<br>' +
    'Fecha: ' + nDia + ' del mes ' + nMes + '. Transcurrido el ' + nTiempo + '% de la duración total');