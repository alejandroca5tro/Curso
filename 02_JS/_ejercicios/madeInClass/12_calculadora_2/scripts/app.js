const prompt = require('prompt'); //para usar prompts dentro de node

(function main () {
	let sumar (a, b) {
		return Number(a) + Number(b);
	}
	let restar (a, b) {
		return a - b;
	}let multiplicar (a, b) {
		return a * b;
	}
	let dividir (a, b) {
		return a / b;
	}let calcular = (pNum1, pNum2, pOp) => {
		let result = ""
		if (pOp = "S") {
			// Suma
			result = sumar(pNum1, pNum2)
		} else if (pOp = "R") {
			// Resta
			result = restar(pNum1, pNum2)
        } else if (pOp = "M") {
			// Multiplicacion
			result = multiplicar(pNum1, pNum2)
        } else if (pOp = "D") {
			// División
			result = dividir(pNum1, pNum2)
		} else {
			// Instrucción no soportada
			result = NaN
		} // Fin del if
    } // Fin de la función calcular

	let mostrarDatos = (pRespuesta) => {
		if (isNaN(pRespuesta)){
			console.log("Operacion no soportada");
		} else {
			console.log(´)
		}
	}
	// Objeto con los mensajes y variables del prompt
	let oDatos = {
		properties : {
			num1 : {
				description : 'Escribe un número',
				default : 24
			},
			num2 : {
				description : 'Escribe otro número',
				default : 12
			},
			op : {
				description : 
				"Selecciona <S>uma, <R>esta, <P>roducto o <D>ivision",
				default : "S"
			}
		}
	}
	// Start the prompt 
	prompt.start();  // 
	// Get prpopiedades del objeto oDatos
	// 
  	prompt.get(oDatos, function (err, result) {
		//Entradas (inputs) recibidas por línea de comandos
		// result {num1, num2, op)		
		let sRespuesta = calcular (result.num1, result.num2, result.op);

		if (isNaN(sRespuesta)){
			console.log("Operación no soportada");
		} else {
			console.log(`El resultado es ${sRespuesta}`);
		}
    	console.log(sRespuesta);
  	});
})();