/*Programa en el que calcularemos estadísticas de ventas durante
un período de tiempo*/
using System;

class Practica {
    static void Main() {
        int periodo, ventasEuros, suma = 0;
        int maximo = 0, minimo = 0;
        double promedio = 0;

        Console.Write("Indica el período en años: ");
        periodo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce las ventas de los {0} años: ", periodo);
        for(int i = 1; i <= periodo; i++) {
            ventasEuros = Convert.ToInt32(Console.ReadLine());
            suma += ventasEuros;

            if(i == 1) {
                maximo = ventasEuros;
                minimo = ventasEuros;
            } 
            if(ventasEuros < minimo) {
                minimo = ventasEuros;
            } else if(ventasEuros > maximo) {
                maximo = ventasEuros;
            }
        }
        promedio = (double)suma / periodo;

        Console.WriteLine("Las ventas mínimas han sido de {0} euros", minimo);
        Console.WriteLine("Las ventas máximas han sido de {0} euros", maximo);
        Console.WriteLine("Las ventas medias han sido de " + 
            promedio.ToString("N2") + " euros");
    }
}