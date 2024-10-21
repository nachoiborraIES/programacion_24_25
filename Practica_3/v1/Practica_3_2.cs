/* Programa quendebe convertir la longitud a la otra unidad. Por ejemplo,
si el usuario escribe una longitud de 50 y unidad = 'C', el programa
debe convertir 50cm a pulgadas
*/
using System;

class Practica {
    static void Main() {
        const double conversion = 2.54;
        double resultado = 0, longitud = 0;
        char unidad;
        bool correcto = false;

        do {  
            try {
                Console.Write("Introduce una longitud: ");
                longitud = Convert.ToDouble(Console.ReadLine());
                correcto = true;                    
            }
            catch (FormatException) {
                Console.WriteLine("Formato incorrecto.");
            }
        } while (!correcto);

        Console.Write("Introduce una unidad: ");
        unidad = Convert.ToChar(Console.ReadLine());

        if (unidad == 'C') {
            resultado = longitud / conversion;
            Console.WriteLine(resultado.ToString("N3"));
        } else if (unidad == 'P') {
            resultado = longitud * conversion;
            Console.WriteLine(resultado.ToString("N3"));
        } else {
            Console.WriteLine("Unidad no válida.");
        }
    }
}