/* Programa que le pida al usuario a qué velocidad lleva el coche (en Km/h) 
 * y a qué distancia está la ciudad a la que quiere llegar (en Km) 
 * y le diga cuántos minutos tardará en llegar.
*/ 
using System;

class Practica2
{
    static void Main()
    {
        int velocidad, distancia, total;
        
        Console.WriteLine("A qué velocidad va el coche (en km/h)?");
        velocidad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A qué distancia está la ciudad a la que" + 
            "quiere llegar (en Km)?");
        distancia = Convert.ToInt32(Console.ReadLine());
        
        total = (distancia * 60) / velocidad;
        
        Console.WriteLine("El coche tardaría {0} minutos en llegar", total);
    }
}
