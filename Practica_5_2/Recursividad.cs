/* Programa que tiene funciones recursivas
 * SumaNumero: la cual se encargara de sumar desde el 1 hasta ese número
 * PalabraOrdenada: que devuelve un booleano indicando si tiene las letras
 * ordenadas ascendetemente o no*/
 
using System;

class Recursividad
{
    static void Main()
    {
        Console.WriteLine(SumaNumero(10));
        Console.WriteLine(SumaNumero(4));
        Console.WriteLine(SumaNumero(-1));
        Console.WriteLine(PalabraOrdenada("dino"));
        Console.WriteLine(PalabraOrdenada("salet"));
        Console.WriteLine(PalabraOrdenada("aa"));
        
    }
    
    static int SumaNumero(int n)
    {
        if(n < 1) 
            return 0;
        else
            return n + SumaNumero(n- 1);
    }
    
    static bool PalabraOrdenada(string palabra)
    {
        if(palabra.Length <= 1) 
            return true;
        else if (palabra[0] > palabra[1])
            return false;
        else
            return PalabraOrdenada(palabra.Substring(1));
    }
}
