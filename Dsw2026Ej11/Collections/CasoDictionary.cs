using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    // Crea el diccionario
    private Dictionary<int, Alumno> _alumnosDiccionario;

    // Constructor
    public CasoDictionary()
    {
        _alumnosDiccionario = new Dictionary<int, Alumno>();
    }

    // Agrega alumno
    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        
        if (!_alumnosDiccionario.ContainsKey(legajo))
        {
            _alumnosDiccionario.Add(legajo, alumno);
        }
    }

    // Busca el alumno utilizando legajo
    public Alumno BuscarAlumno(int legajo)
    {
        
        if (_alumnosDiccionario.ContainsKey(legajo))
        {
            return _alumnosDiccionario[legajo];
        }
        return null;
    }

    // Diccionario completo retoma
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnosDiccionario;
    }

    // Elimina alumno utilizando legajo
    public void EliminarAlumno(int legajo)
    {
        
        _alumnosDiccionario.Remove(legajo);
    }
}