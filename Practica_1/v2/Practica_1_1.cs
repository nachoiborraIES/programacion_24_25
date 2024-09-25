/* Programa que le pida al usuario tres notas de exámenes 
 * y muestre la media de las tres, sin decimales.
*/
using System;

class Practica1
{
    static void Main()
    {
        int nota1, nota2, nota3, total, media;
        
        Console.WriteLine("Escribe 3 notas de exámenes:");
        Console.WriteLine("Nota 1:");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nota 2:");
        nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nota 3:");
        nota3 = Convert.ToInt32(Console.ReadLine());
        
        total = nota1 + nota2 + nota3;
        
        media = total / 3;
        
        Console.WriteLine("La media total de las 3 notas es " + media);
    }
}
