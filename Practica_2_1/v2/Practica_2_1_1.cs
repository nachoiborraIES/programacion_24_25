/* Programa en el que pedimos 3 notas al usuario y decimos si ha mejorado,
 empeorado o ha tenido altibajos */

using System;

class Practica01
{
    static void Main()
    {
        int n1, n2, n3;
        
        Console.WriteLine("Inserta la primera nota: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserta la segunda nota: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserta la tercera nota: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        if (n1 <= n2 && n2 <= n3)
        {
            Console.WriteLine("Has ido mejorando");
        }
        else if (n1 >= n2 && n2 >= n3)
        {
            Console.WriteLine("Has ido empeorando");
        }
        else
        {
            Console.WriteLine("Tienes altibajos");
        }
    }
}
