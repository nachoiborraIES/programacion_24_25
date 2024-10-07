/*Programa que simula una hucha, solicitamos una cantidad
del dinero que quiere ahorrar el usuario. solicitamos las cantidades
que se van ahorrando hasta que el total ahorrado supere o 
iguale el objetivo.*/
using System;

class Practica {
    static void Main() {
        int objAhorrar, cantIngreso,totAhorrado = 0;

        Console.Write("Introduce la cantidad que quieres ahorrar: ");
        objAhorrar = Convert.ToInt32(Console.ReadLine());

        do {
            Console.Write("Ingresa dinero: ");
            cantIngreso = Convert.ToInt32(Console.ReadLine());
            totAhorrado = cantIngreso + totAhorrado;
        } while (totAhorrado < objAhorrar);

        Console.WriteLine("ENHORABUENA! Has ahorrado {0} euros", totAhorrado);
    }
}