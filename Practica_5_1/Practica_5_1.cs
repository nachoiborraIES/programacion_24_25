/* Programa que gestiona un conjunto de juegos de mesa, permitiendo
 * hacer diferentes operaciones con funciones en C# */

using System;

class Practica
{
    enum tipoJuego { ROL=1, INFANTIL, AZAR, PUZZLE, OTROS }
    
    enum opciones {SALIR, NUEVO, BORRAR, CARO, TIPO, ORDENAR, BUSQUEDA, FILTRO}
    
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
    
    static opciones MostrarMenu()
    {
        opciones opcionUsuario;
        Console.WriteLine("1. Nuevo Juego");
        Console.WriteLine("2. Borrar juego");
        Console.WriteLine("3. Juego más caro");
        Console.WriteLine("4. Juegos por tipo");
        Console.WriteLine("5. Ordenar juegos");
        Console.WriteLine("6. Búsqueda avanzada");
        Console.WriteLine("7. Filtrar juegos");
        Console.WriteLine("0. Salir");
        Console.Write("Elige una opción del menú: ");
        opcionUsuario = (opciones)Convert.ToInt32(Console.ReadLine());
        return opcionUsuario;
    }
    
    static int NuevoJuego(juegoMesa[] juegos, ref int cantidad)
    {
        int result;
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
                if(nuevo.precio <= 0)
                {
                    result=1;
                }
                else
                {
                    juegos[cantidad] = nuevo;
                    cantidad++;
                    result=0;
                }
            }
            catch(Exception)
            {
                result=1;
            }   
        }
        else
        {
            result=2;
        }
        return result;
    }
    
    static void MostrarJuego(juegoMesa juego)
    {
        Console.WriteLine("Nombre: "+juego.nombre);
        Console.WriteLine("Edad: "+juego.info.minEdad);
        Console.WriteLine("Jugadores mínimos: "
            +juego.info.minJugadores);
        Console.WriteLine("Jugadores máximos: "
            +juego.info.maxJugadores);
        Console.WriteLine("Tipo: "+juego.tipo);
        Console.WriteLine("Precio: "+juego.precio);
    }
    
    static void BorrarJuego(juegoMesa[] juegos, ref int cantidad)
    {
        int posicion=0;
        if(cantidad > 0)
        {
            for(int i=0;i<cantidad;i++)
            {
                juegoMesa juegoMostrado=juegos[i];
                MostrarJuego(juegoMostrado);
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
    }
    
    static void JuegosMasCaro(juegoMesa [] juegos, int cantidad)
    {
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
            MostrarJuego(juegoMasCaro);        
        }
        else
        {
            Console.WriteLine("No hay juegos");
        }
    }
    
    static void JuegosPorTipo(juegoMesa[] juegos, int cantidad,
        tipoJuego mostrarTipo)
    {
        bool encontrado=false;
        if( mostrarTipo >= tipoJuego.ROL && 
        mostrarTipo <= tipoJuego.OTROS)
        {
            encontrado = false;
            for(int i = 0; i < cantidad;i++)
            {
                if(mostrarTipo == juegos[i].tipo)
                {
                    juegoMesa juegoAMostrar=juegos[i];
                    MostrarJuego(juegoAMostrar);
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
    
    static void OrdenarJuegos(juegoMesa[] juegos, int cantidad)
    {
        if (cantidad > 0)
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (string.Compare(juegos[i].nombre, 
                        juegos[j].nombre) > 0)
                    {
                        juegoMesa auxiliar = juegos[i];
                        juegos[i] = juegos[j];
                        juegos[j] = auxiliar;
                    }
                }
            }
            Console.WriteLine("Los primeros 5 juegos ordenados:");
            for (int i = 0; i < Math.Min(5, cantidad); i++)
            {
                MostrarJuego(juegos[i]);
            }
        }
        else
        {
            Console.WriteLine("No hay juegos");
        }
        Console.WriteLine();
    }
    
    static void BusquedaAvanzada(juegoMesa[] juegos, int cantidad,
        string textoBuscar)
    {
        bool encontrado=false;
        for (int i = 0; i < cantidad; i++)
        {
            if (juegos[i].nombre.ToLower().Contains
                (textoBuscar))
            {
                MostrarJuego(juegos[i]);
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("No se encontraron juegos con " +
                "el texto {0}", textoBuscar);
        }
    }
    
    static void FiltrarJuegos(juegoMesa[] juegos, int cantidad,
        float precioBuscar, tipoJuego mostrarTipo)
    {
        bool encontrado = false; 
        for (int i = 0; i < cantidad; i++) 
        { 
            if ((mostrarTipo == 0 || 
                 juegos[i].tipo == mostrarTipo) &&
                 juegos[i].precio <= precioBuscar) 
            { 
                MostrarJuego(juegos[i]);
                encontrado = true; 
            } 
        } 
        if (!encontrado) 
        { 
            Console.WriteLine("No hay juegos " +
                "con estas características"); 
        }
    }
    
    static void Main()
    {
        opciones opcionUsuario;
        juegoMesa[] juegos = new juegoMesa[50];
        int cantidad = 0;
        tipoJuego mostrarTipo;
        string textoBuscar;
        float precioBuscar;
        int resultJuego;
        
        do
        {
            opcionUsuario=MostrarMenu();
            switch(opcionUsuario)
            {
                case opciones.NUEVO:
                
                    Console.WriteLine("---NUEVO JUEGO---");
                    resultJuego=NuevoJuego(juegos, ref cantidad);
                    switch(resultJuego)
                    {
                        case 0:
                            Console.WriteLine("Se ha insertado correctamente");
                            break;
                        case 1:
                            Console.WriteLine("Precio incorrecto");
                            break;
                        case 2:
                            Console.WriteLine("El catálogo está completo");
                            break;
                    }
                    break;
                    
                case opciones.BORRAR: 
                               
                    Console.WriteLine("---BORRAR JUEGO---");
                    BorrarJuego(juegos, ref cantidad);
                    break;
                    
                case opciones.CARO:
                
                    Console.WriteLine("---JUEGO MÁS CARO---");
                    JuegosMasCaro(juegos, cantidad);
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
                        JuegosPorTipo(juegos, cantidad, mostrarTipo);
                    }
                    else
                    {
                        Console.WriteLine("No hay juegos");                        
                    }
                    break;
                    
                case opciones.ORDENAR:
                
                    Console.WriteLine("---ORDENAR JUEGOS POR NOMBRE---");                    
                    OrdenarJuegos(juegos, cantidad);
                    break;
        
                case opciones.BUSQUEDA:
                
                    Console.WriteLine("---BÚSQUEDA AVANZADA---");                
                
                    if (cantidad > 0)
                    {
                        Console.WriteLine("¿Qué quieres buscar?: ");
                        textoBuscar = Console.ReadLine().ToLower();
                        BusquedaAvanzada(juegos, cantidad, textoBuscar);
                    }
                    else
                    {
                        Console.WriteLine("No hay juegos para buscar.");
                    }
                    break;
                    
                case opciones.FILTRO: 
                
                    Console.WriteLine("---FILTRAR JUEGOS---");                
                
                    if (cantidad > 0) 
                    { 
                        Console.WriteLine("Introduce un precio máximo: "); 
                        precioBuscar = Convert.ToSingle(Console.ReadLine()); 
                        Console.WriteLine("Introduce el tipo de juego (0 para"+
                            " buscar cualquier tipo): "); 
                        Console.WriteLine("--1. ROL\n--2. INFANTIL\n"+
                                "--3. AZAR\n--4. PUZZLE\n--5. OTRO");
                        mostrarTipo = 
                            (tipoJuego)Convert.ToInt32(Console.ReadLine()); 
                        FiltrarJuegos(juegos, cantidad, precioBuscar
                            ,mostrarTipo);
                    }
                    else 
                    { 
                        Console.WriteLine("No existen juegos"); 
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
