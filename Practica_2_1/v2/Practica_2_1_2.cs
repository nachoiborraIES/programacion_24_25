/* Programa que pide al usuarior un código y dependiendo del código dice "hola
 señor" o puede decir "hola señora" */

using System;

class Practica2
{
    static void Main()
    {
        int codigo;
        do
        {
            Console.WriteLine("Introduce un código: ");
            codigo = Convert.ToInt32(Console.ReadLine());
        }
        while(codigo != 5678 && codigo != 8765 && codigo != 1234 && 
        codigo != 4321);
        
        if(codigo == 5678 || codigo == 8765)
        {
            Console.WriteLine("Hola, señor");
        }
        else
        {
            Console.WriteLine("Hola, señora");
        }
    }
}
