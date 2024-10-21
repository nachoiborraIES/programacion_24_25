/*Crea un programa que le pida al usuario una longitud (real) y una unidad 
('P' para pulgadas, 'C' para centímetros). 
El programa debe convertir la longitud a la otra unidad. Por ejemplo, si el 
usuario escribe una longitud de 50 y unidad = 'C', el programa debe convertir 
50cm a pulgadas.*/

using System;
class Practica_3_2
{
    static void Main()
    {
        double longitud = 0, longitudCentimetros, longitudPulgadas;
        char unidad;
        const double CENTIMETROS = 2.54;
        bool correcto = false;
        
        do
        {
            try
            {
                Console.Write("Introduce una longitud: ");
                longitud = Convert.ToDouble(Console.ReadLine());
                correcto = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Los datos introducidos no son correctos");
                Console.WriteLine(e.Message);
            }
        }
        while(!correcto);
        
        Console.Write("Introduce unidad en pulgadas (P) o centimetros (C): ");
        unidad = Convert.ToChar(Console.ReadLine());
    
        if (unidad == 'P')
        {
            longitudCentimetros = longitud * CENTIMETROS;
            Console.Write("{0} pulgadas son {1} centímetros", longitud, 
                longitudCentimetros.ToString("N3"));
        }
        else if (unidad == 'C')
        {
            longitudPulgadas = longitud / CENTIMETROS;
            Console.Write("{0} centímetros son {1} pulgadas", longitud, 
                longitudPulgadas.ToString("N3"));
        }
        else
        {
            Console.WriteLine("Unidad no válida");
        }  
    }
}
