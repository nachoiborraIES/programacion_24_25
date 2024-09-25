/*Pide la velocidad a la que vas, la distancia al objetivo 
y saca los minutos que tardas en llegar*/

using System;

class Ejercicio
{
	static void Main()
	{
		int vel, dist, resultado;

        Console.WriteLine("Escribe a cuantos Km/h vas:");
        vel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe a cuantos Km esta tu destino");
        dist = Convert.ToInt32(Console.ReadLine());
        
        resultado = (dist * 60) / vel;
        
        Console.WriteLine("Tardarías {0} minutos en llegar", resultado);
	}
}
