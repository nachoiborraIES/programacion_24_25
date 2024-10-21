/* Crea un programa en el que calcularemos estadísticas de ventas durante un 
período de tiempo:

- Pediremos al usuario de cuántos años es el período a estudiar (3 años, 
  5 años...)
- Después, le pediremos el total en euros vendido en cada año (tantos totales 
  como número de años haya indicado)
- Finalmente, mostraremos por pantalla las ventas mínimas, máximas y medias 
  introducidas. Para la media, se mostrará formateada con 2 decimales. */

using System;
class Practica_3_1
{
    static void Main()
    {
        int anyosVentas, ventas, totalVentas = 0, ventasMin = 0, ventasMax = 0;
        float mediaVentas;
        
        Console.WriteLine("Indica el periodo en años: ");
        anyosVentas = Convert.ToInt32(Console.ReadLine()); 
        
        Console.WriteLine("Introduce las ventas de los {0} años: ",
            anyosVentas);
        
        for (int i = 1; i <= anyosVentas; i++)
        {
            ventas = Convert.ToInt32(Console.ReadLine());
            totalVentas += ventas;
            
            if (i == 1)
            {
                ventasMax = ventas;
                ventasMin = ventas;
            }
            else
            {
                if (ventas >= ventasMax)
                {
                    ventasMax = ventas;
                }
                else if (ventas <= ventasMin)
                {
                    ventasMin = ventas;
                }
            }
        }
        mediaVentas = (float)totalVentas / anyosVentas;
        
        Console.WriteLine("Las ventas mínimas han sido de {0} euros", 
            ventasMin);
        Console.WriteLine("Las ventas máximas han sido de {0} euros", 
            ventasMax);
        Console.WriteLine("Las ventas medias han sido de {0} euros", 
            mediaVentas.ToString("N2"));
    }
}
