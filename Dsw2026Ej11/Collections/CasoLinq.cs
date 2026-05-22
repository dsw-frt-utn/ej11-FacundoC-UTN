namespace Dsw2026Ej11.Collections;
using System.Linq; 
using Dsw2026Ej11.Domain;

public class CasoLinq
{
    // Lista de libros activa
    private List<Libro> _libros;

    // Se cargan los libros 
    public CasoLinq()
    {
        _libros = Libro.CrearLista();
    }

    // Obtenemos el primer libro del listado
    public Libro GetPrimero()
    {
       
        return _libros.First();
    }

    // Obtenemos el ultimo libro del listado
    public Libro GetUltimo()
    {
        
        return _libros.Last();
    }

    // Obtenemos la suma de los precios
    public decimal GetTotalPrecios()
    {
        // Recorre y suma
        return _libros.Sum(l => l.Precio);
    }

    // Saca el promedio 
    public decimal GetPromedioPrecios()
    {
        
        return _libros.Average(l => l.Precio);
    }

    // Obtenemos la lista con el filtro
    public List<Libro> GetListById()
    {
        
        return _libros.Where(l => l.Id > 15).ToList();
    }

    // Lista de los libros con su formato correcto y precio 
    public List<string> GetLibros()
    {

        return _libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();
    }

    // El libro con el precio mas alto
    public Libro GetMayorPrecio()
    {
        // Ordena y queda con el primero
        return _libros.OrderByDescending(l => l.Precio).First();
    }

    // Precio mas bajo
    public Libro GetMenorPrecio()
    {
        // Ordena y queda con el ultimo
        return _libros.OrderBy(l => l.Precio).First();
    }

    // Aquellos que tengan precio mayor al promedio
    public List<Libro> GetMayorPromedio()
    {
        
        decimal promedio = GetPromedioPrecios();
        
        // Filtrado
        return _libros.Where(l => l.Precio > promedio).ToList();
    }

    // Ordenados de forma descendente
    public List<Libro> GetLibrosOrdenadosDesc()
    {
        
        return _libros.OrderByDescending(l => l.Titulo).ToList();
    }
}