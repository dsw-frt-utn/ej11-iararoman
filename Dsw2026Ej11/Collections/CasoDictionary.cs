namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;


public class CasoDictionary
{
    //Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private Dictionary<int, Alumno> AlumnosDiccionario = new Dictionary<int, Alumno>();

    //Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumnoDiccionario(Alumno alumno)
    {
        AlumnosDiccionario.Add(alumno.Id, alumno);
    }

    //Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return AlumnosDiccionario;
    }

    //Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumnoClave(int id)
    {
        AlumnosDiccionario.Remove(id);
    }

    //Incluir un método para buscar un alumno utilizando la clave
    public Alumno? BuscarALumno(int id)
    {
        if(AlumnosDiccionario.ContainsKey(id))
        {
            return AlumnosDiccionario[id];
        }
        return null;
    }
}
