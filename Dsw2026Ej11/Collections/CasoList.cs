namespace Dsw2026Ej11.Collections;
using System.Linq; 
using Dsw2026Ej11.Domain;

public class CasoList
{
    // Lista de alumnos
    private List<Alumno> _alumnos;

    // Constructor con lista vacia
    public CasoList()
    {
        _alumnos = new List<Alumno>();
    }

    // Agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        
        _alumnos.Add(alumno);
    }

    // Retoma la lista
    public List<Alumno> ObtenerLista()
    {
        return _alumnos;
    }

    // Busqueda de alumno por nombre
    public Alumno BuscarPorNombre(string nombre)
    {
        // .FirstOrDefault() busca el primero que coincida con el nombre.
        // No importa el metodo de escritura(mayus o minus) lo va encontrar igual
        return _alumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, System.StringComparison.OrdinalIgnoreCase));
    }

    // Eliminar el alumno
    public void EliminarAlumno(Alumno alumno)
    {
       
        _alumnos.Remove(alumno);
    }

    // Elimina el alumno en una posicion especifica de la lista
    public void EliminarEnPosicion(int posicion)
    {
        // Verificacion del numero ingresado
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            //Remueve alumno en la posicion teniendo en cuenta que arranca contando desde 0
            _alumnos.RemoveAt(posicion);
        }
    }
}
