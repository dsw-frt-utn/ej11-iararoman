using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    
    public static void EjemploList()
    {
        CasoList miCasoList = new CasoList();

        //Agregar 3 alumnos a la lista
        Alumno alumno1 = new Alumno(1, "Gabriel", 9.5);
        Alumno alumno2 = new Alumno(2, "Iara", 8.5);
        Alumno alumno3 = new Alumno(3, "Maria", 7);


        miCasoList.AgregarAlumno(alumno1);
        miCasoList.AgregarAlumno(alumno2);
        miCasoList.AgregarAlumno(alumno3);

        //Listar por consola los alumnos
        Console.WriteLine("\nLista de Alumnos");

        List<Alumno> listaCompleta = miCasoList.ObtenerLista();
        foreach (Alumno alumno in listaCompleta)
        {
            Console.WriteLine(alumno);
        }

        //Buscar por nombre un alumno que exista y mostrar por consola
        Console.WriteLine("\nBuscando Alumno...");

        Alumno? alumnoEncontrado = miCasoList.BuscarAlumno("Gabriel");
        if (alumnoEncontrado != null)
        {
            Console.WriteLine($"\nAlumno Encontado : {alumnoEncontrado}");
        }

        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        Console.WriteLine("\nBuscando Alumno...");

        Alumno? alumnoNoEncontrado = miCasoList.BuscarAlumno("Pedro");
        if (alumnoNoEncontrado == null)
        {
            Console.WriteLine("\nNo Existe");
        }
        //Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\nEliminando alumno...");

        miCasoList.EliminarAlumno(alumno3);

        List<Alumno> listaActualizada = miCasoList.ObtenerLista();
        foreach (Alumno alumno in listaCompleta)
        {
            Console.WriteLine(alumno);
        }

        //Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\nEliminando alumno de la primera posición...");

        miCasoList.EliminarAlumnoEnPosicion(0);

        var listaFinal = miCasoList.ObtenerLista();
        foreach (var alumno in listaFinal)
        {
            Console.WriteLine(alumno);
        }
    }

    
    public static void EjemploDictionary()
    {
        CasoDictionary miCasoDictionary = new CasoDictionary();

        //Agregar 3 alumnos al diccionario

        Alumno alumno1 = new Alumno(1, "Gabriel", 9.5);
        Alumno alumno2 = new Alumno(2, "Iara", 8.5);
        Alumno alumno3 = new Alumno(3, "Maria", 7);

        miCasoDictionary.AgregarAlumnoDiccionario(alumno1);
        miCasoDictionary.AgregarAlumnoDiccionario(alumno2);
        miCasoDictionary.AgregarAlumnoDiccionario(alumno3);

        //Listar por consola los alumnos
        Console.WriteLine("\nLista de Alumnos");
        var diccionario = miCasoDictionary.ObtenerDiccionario();
        foreach(var alumno in diccionario)
        {
            Console.WriteLine(alumno);
        }

        //Buscar un alumno por clave y mostrar por consola
        Console.WriteLine("\nBuscando alumno...");
        var alumnoEncontrado = miCasoDictionary.BuscarALumno(1);
        Console.WriteLine($"\nAlumno encontrado: {alumnoEncontrado}");

        //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
        Console.WriteLine("\nBuscando alumno...");
        var alumnoNoEncontrado = miCasoDictionary.BuscarALumno(5);
        if(alumnoNoEncontrado == null)
        {
            Console.WriteLine("\nNo existe");
        }
        //Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\nELiminando alumno...");
        miCasoDictionary.EliminarAlumnoClave(3);
        var listaFinal = miCasoDictionary.ObtenerDiccionario();
        foreach(var alumno in listaFinal)
        {
            Console.WriteLine(alumno);
        }
        

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda

    //*1.Obtener el primer libro(GetPrimero)
    //* 2.Obtener el último libro(GetUltimo)
    //* 3.Obtener la suma de precios(GetTotalPrecios)
    // *4.Obtener el promedio de precios(GetPromedioPrecios)
    // *5.Obtener la lista de libros con Id mayor a 15(GetListById)
    // * 6.Obtener una lista de cada libro con su título y precio en formato moneda(GetLibros)(debe retornar una lista de string)
    // * 7.Obtener el libro con el precio más alto(GetMayorPrecio)
    // * 8.Obtener el libro con el precio más bajo(GetMenorPrecio)
    // * 9.Obtener los libros cuyo precio sea mayor al promedio(GetMayorPromedio)
    // *10.Obtener los libros ordenados por título de forma descendente
    public static void EjemploLinq()
    {
        CasoLinq miCasoLinq = new CasoLinq();

        //*1.Obtener el primer libro(GetPrimero)
        Console.WriteLine("\nObteniendo el primer libro...");
        var primerLibro = miCasoLinq.GetPrimero();
        Console.WriteLine(primerLibro);

        //* 2.Obtener el último libro(GetUltimo)
        Console.WriteLine("\nObteniendo el ultimo libro...");
        var ultimoLibro = miCasoLinq.GetUltimo();
        Console.WriteLine(ultimoLibro);

        //* 3.Obtener la suma de precios(GetTotalPrecios)
        Console.WriteLine("\nObteniendo la suma de precios...");
        var suma = miCasoLinq.GetTotalPrice();
        Console.WriteLine($"{suma:C}");

        // *4.Obtener el promedio de precios(GetPromedioPrecios)
        Console.WriteLine("\nObteniendo el promedio de los precios...");
        var promedio = miCasoLinq.GetPromedioPrecios();
        Console.WriteLine($"{promedio:F2}");

        // *5.Obtener la lista de libros con Id mayor a 15(GetListById)
        Console.WriteLine("\nObteniendo la lista de libros con Id mayor a 15...");
        var libroMayorA15 = miCasoLinq.GetListById();
        foreach(var libro in libroMayorA15)
        {
            Console.WriteLine(libro);
        }

        // * 6.Obtener una lista de cada libro con su título y precio en formato moneda(GetLibros)(debe retornar una lista de string)
        Console.WriteLine("\nObteniendo lista de libros...");
        var listaLibros = miCasoLinq.GetLibros();
        foreach(var libro in listaLibros)
        {
            Console.WriteLine(libro);
        }

        // * 7.Obtener el libro con el precio más alto(GetMayorPrecio)
        Console.WriteLine("\nObteniendo libro con el precio mas alto...");
        var libroMasAlto = miCasoLinq.GetMayorPrecio();
        Console.WriteLine(libroMasAlto);

        // * 8.Obtener el libro con el precio más bajo(GetMenorPrecio)
        Console.WriteLine("\nObteniendo libro con menor precio");
        var libroMasBajo = miCasoLinq.GetMenorPrecio();
        Console.WriteLine(libroMasBajo);

        // * 9.Obtener los libros cuyo precio sea mayor al promedio(GetMayorPromedio)
        Console.WriteLine("\nObteniendo lista de libros cuyo precio es mayor al promedio...");
        var listaLibrosMayor = miCasoLinq.GetMayorPromedio();
        foreach (var libro in listaLibrosMayor)
        {
            Console.WriteLine(libro);
        }

        // *10.Obtener los libros ordenados por título de forma descendente
        Console.WriteLine("\nObteniendo lista de libros ordenados por titulo de forma descendente...");
        var listaLibrosDescendente = miCasoLinq.ObtenerLibrosDesc();
        foreach(var libro in listaLibrosDescendente)
        {
            Console.WriteLine(libro);
        }
    }
}
