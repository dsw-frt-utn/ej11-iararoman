namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;






public class CasoList
{
    //Crear un campo que represente una lista de alumnos (List<>)
    private List<Alumno> Alumnos = new List<Alumno>();

    //Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumnoNuevo)
    {
        Alumnos.Add(alumnoNuevo);
    }

    //Incluir un método para retornar la lista
    public List<Alumno> ObtenerLista()
    {
        return Alumnos;
    }

    //Incluir un método para buscar un alumno por nombre
    public Alumno? BuscarAlumno(string nombreAlumno)
    {
        return Alumnos.Find(a => a.Nombre == nombreAlumno);
    }

    //Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        Alumnos.Remove(alumno);
    }

    //Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoEnPosicion(int posicion)
    {
        Alumnos.RemoveAt(posicion);
    }

}
