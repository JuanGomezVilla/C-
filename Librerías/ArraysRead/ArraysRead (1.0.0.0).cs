using System;
using System.Collections.Generic;

namespace ArraysRead {
	public class ArrayRead {
		public static void imprimirLista(int[] lista){
			for(int i=0; i<lista.Length; i++){
				Console.Write(lista[i]);
				if(i != lista.Length - 1){
					Console.Write(", ");
				}
			}
			Console.WriteLine();
		}
	}
}
