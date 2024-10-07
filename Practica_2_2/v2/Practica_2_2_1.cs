/* Crea un programa en un archivo llamado Practica_2_2_1.cs que le pida al 
usuario una altura h y dibuje una figura como la que se muestra a continuación 
con la altura indicada (alineada al margen izquierdo). El programa debe mostrar 
el mensaje "Altura no válida" si se introduce una altura negativa o no entera 
(debes capturar la excepción correspondiente). */

using System;
class Practica_2_2_1
{
    static void Main()
    {
        int altura, espacio, asterisco;

        try
        {
            Console.WriteLine("Introduce la altura del triángulo:");
            altura = Convert.ToInt32(Console.ReadLine());
            
            if (altura >= 1)
            { 
                asterisco = 1;
                espacio = altura - 1;

                for (int i = 1; i <= altura; i++)
                {
                    for (int j = 1; j <= espacio; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= asterisco; j++)
                    {
                        Console.Write("*");
                    }
                    espacio--;
                    asterisco += 2;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Altura no válida");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Altura no válida");
            Console.WriteLine(e.Message);
        }
    }
}


