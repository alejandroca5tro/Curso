document.addEventListener('DOMContentLoaded', main);

function main() {
    let sName = 'Luis'
    let sCurso = 'Desarrollo Web full-stack';
    new Formulario(sName, sCurso).controller();
}