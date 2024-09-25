//Pide la nota de 3 examenes y saca la media

using System;

class Ejercicio
{
	static void Main()
	{
		int n1, n2, n3, med;

        Console.WriteLine("Escribe la nota del primer examen:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la nota del segundo examen:");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la nota del tercer examen:");
        n3 = Convert.ToInt32(Console.ReadLine());
        
        med = (n1 + n2 + n3) / 3;
        
        Console.WriteLine("La media de los 3 examenes es: {0}", med);
	}
}
