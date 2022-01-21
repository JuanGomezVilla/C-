using System;

namespace Mosaico {
	class Programa {
		public static void Main(string[] args) {
			Console.Title = "Mosaico";								//Título de la ventana
			
			Console.Write("Dígitos de la base: ");					//Cantidad de dígitos de la base
			int numerosBase = Convert.ToInt32(Console.ReadLine());	//Se lee la línea y se convierte a un número entero
			Console.WriteLine();									//Se aplica un salto de línea
			
			Console.Write("Carácter: ");							//Carácter del mosaico
			char caracter = Convert.ToChar(Console.ReadLine());		//Se lee la línea y se convierte a carácter
			Console.WriteLine();									//Se aplica un salto de línea
			
			int espacio = numerosBase;								//Espacios desde el margen hasta la primera letra
			int veces = 1;											//Veces que se repite la letra por cada línea
			
			//Bucle para cada línea
			for(int i=0; i<numerosBase; i++){
				for(int z=0; z<espacio; z++){						//Bucle para el espacio del margen y la línea
					Console.Write(" ");								//Se aplica un espacio
				}
				
				for(int t=0; t<veces; t++){							//Bucle para dibujar los caracteres
					Console.Write(caracter +" ");					//El programa dibuja el carácter indicado
				}
				
				Console.WriteLine();								//Finaliza con un salto de línea
				veces++;											//Aumenta las veces que se repite el carácter en una línea
				espacio--;											//Retira el número de espacios
			}
			
			Console.ReadKey(true);
		}
	}
}