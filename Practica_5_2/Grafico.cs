/* El programa debera usar una expresion lambda para guardar 
 * los datos en un array numerico y escribir la cantidad de asteriscos que estan
 * guardados */

using System;

class Grafico
{
    static void DibujarLinea(int cantidad)
    {
        Console.WriteLine(new string('*', cantidad));
    }
    static void Main(string[] args)
    {
        try
        {
            if(args.Length > 0)
            {
                int[] conversion =
                    Array.ConvertAll(args, arg => Convert.ToInt32(arg));
                Array.ForEach(conversion, DibujarLinea);
            }
            else
            {
                Console.WriteLine("Datos de entrada inválidos");
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Datos de entrada inválidos");
        }
        
    }
}
