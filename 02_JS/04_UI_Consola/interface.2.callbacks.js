const readline = require('readline');
var rl = readline.createInterface({
	input: process.stdin,
	output: process.stdout
});

const pedirDatos = (rl) => {
	let cUsuario, cCurso, nDia, nMes, nTiempo = 180;

	rl.question('Nombre de usuario ', (cUsuario) => {
		rl.question('Nombre del curso ', (cCurso) => {
			rl.question('Dia de inicio ', (nDia) => {	
				rl.question('Mes de inicio (en número) ', (nMes) => {	
					mostrarResultado (cUsuario, cCurso, nDia, nMes, nTiempo)
					rl.close();
				}); // Fin del método question		
			}); // Fin del método question
		}); // Fin del método question
	}) // Fin del método question

}

const mostrarResultado = (pUsuario, pCurso, pDia, pMes, pTiempo) => {
	console.log('')
	console.log(`Hola ${pUsuario}`);
	console.log(`Bienvenido al curso: ${pCurso}`);
	console.log(`Que empieza el día ${pDia} del mes ${pMes}`);
	console.log(`con una duración de ${pTiempo} horas`)
}

pedirDatos(rl);