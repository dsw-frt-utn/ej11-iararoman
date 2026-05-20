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
    public static void EjemploLinq()
    {

    }
}
