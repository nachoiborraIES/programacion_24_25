/*Crea un programa en un archivo llamado Practica_2_2_2.cs que simule una hucha. 
El programa solicitará primero una cantidad, que será la cantidad de dinero que 
queremos ahorrar. A continuación, el programa solicitará una y otra vez las 
cantidades que se irán ahorrando, hasta que el total ahorrado iguale o supere al 
objetivo. El programa no comprobará que las cantidades sean positivas. */

using System;
class Practica_2_2_2
{
    static void Main()
    {
        int objetivo, totalAhorrado = 0, ingreso;
        
        Console.WriteLine("Indica la cantidad a ahorrar:");
        objetivo = Convert.ToInt32(Console.ReadLine());
        
        do
        {
            Console.Write("Indica la cantidad que ingresas: ");
            ingreso = Convert.ToInt32(Console.ReadLine());
            totalAhorrado = totalAhorrado + ingreso;
        }
        while (totalAhorrado < objetivo);
        Console.WriteLine("ENHORABUENA! Has ahorrado {0} euros", totalAhorrado);
    }
}
