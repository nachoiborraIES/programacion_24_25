//Programa que muestra un mensaje en función de las notas de un alumno
using System;
class ejercicio
{
    static void Main()
    {
        int n1, n2, n3;
        Console.WriteLine("Dime la nota de tus tres ultimos exámenes");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        
        if(n3 <= n2 && n2 <= n1)
            Console.WriteLine("{0} {1} {2} --> Has ido empeorando", n1, n2, n3);
        else if(n3 >= n2 && n2 >= n1)
            Console.WriteLine("{0} {1} {2} --> Has ido mejorando", n1, n2, n3);
        else
            Console.WriteLine("{0} {1} {2} --> Tienes altibajos", n1, n2, n3);
    }
}

