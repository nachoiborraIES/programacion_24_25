/* Programa que dibuja un triángulo de altura h, la indica el usuario,
capturamos con una excepción también en caso de altura negativa o no entera
*/
using System;

class Practica {
    static void Main() {
        int tam;

        try {
            Console.Write("Introduce el tamaño de la figura: ");
            tam = Convert.ToInt32(Console.ReadLine());

            if(tam < 0) {
                Console.WriteLine("Error: Altura no válida.");
            } else {
                for (int i = 1; i <= tam; i++) {
                    for (int j = 1; j <= tam - i; j++) {
                        Console.Write(" ");
                    }
                    // Realizamos la operación(2 * i - 1)para quitar los pares
                    // y dibujar los impares
                    for(int k = 1; k <= (2 * i - 1) ; k++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }          
            }            
        } //Capturamos la excepción en caso de que la altura no sea un entero.
        catch (FormatException e) {
            Console.WriteLine("Error: Altura no válida. ");
            Console.WriteLine(e.Message);
        }
    }
}