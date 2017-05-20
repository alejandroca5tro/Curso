const prompt = require('prompt'); //Esto es instanciar a una librería externa.
 
// 
// Start the prompt 
// 
prompt.start();
 
var oDatos = {
	properties : {
		usuario : {
			description : 'Nombre de usuario'
		},
		curso : {
			description : 'Nombre del curso',
			default : 'Desarrollo Web'
		},
		dia : {
			description : "Dia de inicio",
			default : 27
		},
		mes : {
			description : "Mes de inicio (en número)",
			default : 4
		}
		//	var nTiempo = 33.5;
	}
}
  // 
  // Get prpopiedades del objeto oDatos
  // 
  prompt.get(oDatos, function (err, result) {
	// 
	// Log the results. 
	// 
	console.log("")
	console.log('Entradas (inputs) recibidas por línea de comandos :');
	console.log(`Bienvenido alumno ${result.usuario}`);//Esto es una interpolación echo con lo más nuevo de ES6 (comillas chungas)
	console.log(`del curso "${result.curso}"`);
	console.log(`Comenzaremos el día ${result.dia} del mes ${result.mes}` )

	//	'<p>Tiempo transcurrido de curso: <b>' + nTiempo + '%</b> del total.</p>');
  });





