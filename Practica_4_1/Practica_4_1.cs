/* Programa que gestiona un conjunto de juegos de mesa, permitiendo
 * añadir, borrar o buscar por algunos criterios */

using System;

class Practica
{
    enum tipoJuego { ROL=1, INFANTIL, AZAR, PUZZLE, OTROS }
    
    enum opciones { SALIR, NUEVO, BORRAR, CARO, TIPO }
    
    struct informacionBasica
    {
        public int minEdad;
        public int minJugadores;
        public int maxJugadores;
    }
    
    struct juegoMesa
    {
        public string nombre;
        public float precio;
        public tipoJuego tipo;
        public informacionBasica info;
        
    }
    
    static void Main()
    {
        opciones opcionUsuario;
        juegoMesa[] juegos = new juegoMesa[50];
        int cantidad = 0, posicion;
        tipoJuego mostrarTipo;
        bool encontrado;
        
        do
        {
            Console.WriteLine("1. Nuevo Juego");
            Console.WriteLine("2. Borrar juego");
            Console.WriteLine("3. Juego más caro");
            Console.WriteLine("4. Juegos por tipo");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción del menú: ");
            
            opcionUsuario = (opciones)Convert.ToInt32(Console.ReadLine());
            
            switch(opcionUsuario)
            {
                case opciones.NUEVO:
                
                    Console.WriteLine("---NUEVO JUEGO---");
                    
                    if(cantidad < juegos.Length)
                    {
                        juegoMesa nuevo;
                        Console.WriteLine("Nombre del juego: ");
                        nuevo.nombre = Console.ReadLine();
                        Console.WriteLine("Información básica: ");
                        Console.WriteLine("--Edad mínima: ");
                        nuevo.info.minEdad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--Mínimo número de jugadores: ");
                        nuevo.info.minJugadores = 
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--Máximo número de jugadores: ");
                        nuevo.info.maxJugadores = 
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tipo de juego: ");
                        Console.WriteLine("--1. ROL\n--2. INFANTIL\n"+
                            "--3. AZAR\n--4. PUZZLE\n--5. OTRO");
                        nuevo.tipo = 
                            (tipoJuego)Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Precio: ");
                        try
                        {
                            nuevo.precio = Convert.ToSingle(Console.ReadLine());
                            if(nuevo.precio < 0)
                            {
                                Console.WriteLine("Precio no válido");
                            }
                            else
                            {
                                juegos[cantidad] = nuevo;
                                cantidad++;
                            }
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Precio no válido");
                        }   
                    }
                    else
                    {
                        Console.WriteLine("No caben más juegos");
                    }
                    break;
                    
                case opciones.BORRAR:
                
                    Console.WriteLine("---BORRAR JUEGO---");
                    
                    if(cantidad > 0)
                    {
                        for(int i = 0; i < cantidad;i++)
                        {
                            Console.WriteLine("{0}. {1}", i+1, juegos[i].nombre);
                        }
                        
                        Console.WriteLine("Posición del juego a borrar:");
                        posicion = Convert.ToInt32(Console.ReadLine());
                        posicion--;
                        if(posicion >= 0 && posicion < cantidad)
                        {
                            Console.WriteLine("¿Estás seguro? S/N:");
                            char confirmar = Convert.ToChar(Console.ReadLine());
                            if(confirmar == 'S' || confirmar == 's')
                            {
                                for(int i = posicion; i < cantidad-1; i++)
                                {
                                    juegos[i] = juegos[i+1];   
                                }
                                cantidad--;
                            }
                            else
                            {
                                Console.WriteLine("Cancelado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Posición incorrecta");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay juegos que borrar");
                    }
                    break;
                    
                case opciones.CARO:
                
                    Console.WriteLine("---JUEGO MÁS CARO---");
                    
                    if(cantidad > 0)
                    {
                        juegoMesa juegoMasCaro = juegos[0];
                        for(int i = 1; i < cantidad;i++)
                        {
                            if(juegos[i].precio > juegoMasCaro.precio)
                            {
                                juegoMasCaro = juegos[i];
                            }   
                        }
                        Console.WriteLine("Nombre: "+juegoMasCaro.nombre);
                        Console.WriteLine("Edad: "+juegoMasCaro.info.minEdad);
                        Console.WriteLine("Jugadores mínimos: "  
                            +juegoMasCaro.info.minJugadores);
                        Console.WriteLine("Jugadores máximos: "
                            +juegoMasCaro.info.maxJugadores);
                        Console.WriteLine("Tipo: "+juegoMasCaro.tipo);
                        Console.WriteLine("Precio: "+juegoMasCaro.precio);
                        Console.WriteLine();
                              
                    }
                    else
                    {
                        Console.WriteLine("No hay juegos");
                    }
                    break;
                    
                case opciones.TIPO:
                
                    Console.WriteLine("---JUEGOS POR TIPO---");
                    
                    if (cantidad > 0)
                    {
                        Console.WriteLine("--1. ROL\n--2. INFANTIL\n"+
                                "--3. AZAR\n--4. PUZZLE\n--5. OTRO");
                        Console.Write("Elige tipo: ");
                        
                        mostrarTipo =
                            (tipoJuego)Convert.ToInt32(Console.ReadLine());
                        
                        if( mostrarTipo >= tipoJuego.ROL && 
                            mostrarTipo <= tipoJuego.OTROS)
                        {
                            encontrado = false;
                            for(int i = 0; i < cantidad;i++)
                            {
                                if(mostrarTipo == juegos[i].tipo)
                                {
                                    Console.WriteLine("Nombre: "
                                        +juegos[i].nombre);
                                    Console.WriteLine("Edad: "
                                        +juegos[i].info.minEdad);
                                    Console.WriteLine("Jugadores mínimos: "
                                        +juegos[i].info.minJugadores);
                                    Console.WriteLine("Jugadores máximos: "
                                        +juegos[i].info.maxJugadores);
                                    Console.WriteLine("Tipo: "
                                        +juegos[i].tipo);
                                    Console.WriteLine("Precio: "
                                        +juegos[i].precio);
                                    Console.WriteLine();
                                    encontrado = true;
                                }  
                            }
                            if(!encontrado)
                            {
                                Console.WriteLine("No hay juegos de ese tipo");   
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tipo inválido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay juegos");                        
                    }
                    break;

                case opciones.SALIR:
                    Console.WriteLine("FIN DE PROGRAMA");
                    break;
            }
        }
        while(opcionUsuario != opciones.SALIR);
    }
}
