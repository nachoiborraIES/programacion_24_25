//Programa que muestra un mensaje dependiendo del número que pongas
using System;
class ejercicio
{
    static void Main()
    {
        int n;        
        do
        {
            Console.WriteLine("Dime un número entero de 4 cifras");
            n = Convert.ToInt32(Console.ReadLine());
        }while(n != 1234 && n != 4321 && n != 5678 && n != 8765);
        if( n == 1234 || n == 4321)
            Console.WriteLine("Hola, señora");
        else
            Console.WriteLine("Hola, señor");
    }
}

