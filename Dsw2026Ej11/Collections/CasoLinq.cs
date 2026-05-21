namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Linq;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> Libros = Libro.CrearLista();

    //1. Obtener el primer libro (GetPrimero)
    public Libro? GetPrimero()
    {
        return Libros.FirstOrDefault();
    }

    //2. Obtener el último libro (GetUltimo)
    public Libro? GetUltimo()
    {
        return Libros.LastOrDefault();
    }

     //3. Obtener la suma de precios(GetTotalPrecios)

    public decimal GetTotalPrice()
    {
        return Libros.Sum(l => l.Precio);
    }

    // 4. Obtener el promedio de precios (GetPromedioPrecios)
    public decimal GetPromedioPrecios()
    {
        return (decimal)Libros.Average(l => l.Precio);
    }

    // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public List<Libro> GetListById()
    {
        return Libros.Where(l => l.Id > 15).ToList();
    }

    //6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
    public List<string> GetLibros()
    {
        return Libros.Select(l => ($"{l.Titulo} - {l.Precio:C} ")).ToList();
    }

    // * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
    public Libro? GetMayorPrecio()
    {
        return Libros.MaxBy(l => l.Precio);
    }

    // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
    public Libro? GetMenorPrecio()
    {
        return Libros.MinBy(l => l.Precio);
    }

    // * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPromedio()
    { 
        var promedio = Libros.Average(l => l.Precio);
        return Libros.Where(l => l.Precio > promedio).ToList();
    }

    //10. Obtener los libros ordenados por título de forma descendente
    public List<Libro> ObtenerLibrosDesc()
    {
        return Libros.OrderByDescending(l => l.Titulo).ToList();
    }
}
