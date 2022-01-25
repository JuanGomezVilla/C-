using System;
using System.Collections.Generic;

namespace Scanner {
	/*
	 Librería Scanner:
	 	Versión: 1.0.0.0
		Pasos:
			1. Añadir referencia al proyecto
			2. Escribir en la cabecera del archivo .cs "using Scanner;" sin las comillas
			3. Los dos pasos anteriores se basa en importar la librería al proyecto
			4. Los métodos devuelven valores (return)
			5. Para que el usuario escriba un dato, se escribe el siguiente esquema: leer.Tipo_de_variable("Texto del mensaje: ");
					Ejemplo: int numero = leer.Int("Número: ");
			6. Excepto en el método leer.String, se puede añadir un segundo parámetro, que es el mensaje que
			   devuelve la consola si el usuario escribe un valor incorrecto.
					Ejemplo: int numero = leer.Int("Número: ", "El valor escrito es incorrecto");
	 	Tipos de variables:
	 		-STRING
	 		-INT 32
	 		-DOUBLE
	 		-DECIMAL
	 		-CHAR
	 		-BOOLEAN
	 		-BYTE
	*/
	public class leer {
		//STRING
		public static string String(string texto="Texto: "){
			Console.Write(texto);
			return Convert.ToString(Console.ReadLine());
		}
		
		//INT 32
		public static int Int(string texto="Número: ", string textoError="Error del valor escrito..."){
			while(true){
				Console.Write(texto);
				try {
					return Convert.ToInt32(Console.ReadLine());
				} catch {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(textoError);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}
		
		//DOUBLE
		public static double Double(string texto="Número: ", string textoError="Error del valor escrito..."){
			while(true){
				Console.Write(texto);
				try {
					return Convert.ToDouble(Console.ReadLine());
				} catch {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(textoError);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}
		
		//DECIMAL
		public static decimal Decimal(string texto="Número decimal: ", string textoError="Error del valor escrito..."){
			while(true){
				Console.Write(texto);
				try {
					return Convert.ToDecimal(Console.ReadLine());
				} catch {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(textoError);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}
		
		//CHAR
		public static char Char(string texto="Letra: ", string textoError="Error del valor escrito..."){
			while(true){
				Console.Write(texto);
				try {
					return Convert.ToChar(Console.ReadLine());
				} catch {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(textoError);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}
		
		//BOOLEAN
		public static bool Boolean(string texto="TRUE/FALSE: ", string textoError="Error del valor escrito..."){
			while(true){
				Console.Write(texto);
				try {
					return Convert.ToBoolean(Console.ReadLine());
				} catch {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(textoError);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}
		
		//BYTE
		public static byte Byte(string texto="Byte: ", string textoError="Error del valor escrito..."){
			while(true){
				Console.Write(texto);
				try {
					return Convert.ToByte(Console.ReadLine());
				} catch {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(textoError);
					Console.ForegroundColor = ConsoleColor.White;
				}
			}
		}
	}
}