using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{

    public static void EjemploList()
    {
        Console.WriteLine("=== EJEMPLO CON LIST ===");
        // Instanciamos la clase que maneja nuestra lista
        CasoList casoList = new CasoList();

        // 1. Creamos y agregamos 3 alumnos
        Alumno a1 = new Alumno(101, "Ana", 8.5);
        Alumno a2 = new Alumno(102, "Carlos", 7.0);
        Alumno a3 = new Alumno(103, "Beatriz", 9.2);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        // 2. Listar por consola los alumnos
        Console.WriteLine("\n-- Lista inicial de alumnos --");
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno); //ToString es clave
        }

        // 3. Buscar por nombre un alumno que exista
        Console.WriteLine("\n-- Buscando a 'Carlos' --");
        Alumno encontrado = casoList.BuscarPorNombre("Carlos");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // 4. Buscar por nombre un alumno que no exista
        Console.WriteLine("\n-- Buscando a 'Pedro' --");
        Alumno noEncontrado = casoList.BuscarPorNombre("Pedro");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // 5. Eliminar un alumno y listar
        Console.WriteLine("\n-- Eliminando a 'Ana' --");
        casoList.EliminarAlumno(a1);
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }

        // 6. Eliminar el primer elemento de la lista y listar
        Console.WriteLine("\n-- Eliminando el primer elemento (Posición 0) --");
        casoList.EliminarEnPosicion(0);
        foreach (var alumno in casoList.ObtenerLista())
        {
            Console.WriteLine(alumno);
        }
    }

   
    public static void EjemploDictionary()
    {
        Console.WriteLine("=== EJEMPLO CON DICTIONARY ===");
        CasoDictionary casoDict = new CasoDictionary();

        Alumno a1 = new Alumno(201, "Laura", 8.8);
        Alumno a2 = new Alumno(202, "Marcos", 6.5);
        Alumno a3 = new Alumno(203, "Sofía", 9.5);

        // 1. Agregar 3 alumnos al diccionario (usamos su ID como clave)
        casoDict.AgregarAlumno(201, a1);
        casoDict.AgregarAlumno(202, a2);
        casoDict.AgregarAlumno(203, a3);

        // 2. Listar por consola los alumnos
        Console.WriteLine("\n-- Diccionario inicial --");
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo {kvp.Value}");
        }

        // 3. Buscar un alumno por clave y mostrar
        Console.WriteLine("\n-- Buscando legajo 202 --");
        Alumno encontrado = casoDict.BuscarAlumno(202);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // 4. Buscar un alumno por clave que no exista
        Console.WriteLine("\n-- Buscando legajo 999 --");
        Alumno noEncontrado = casoDict.BuscarAlumno(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // 5. Eliminar un alumno por clave y listar
        Console.WriteLine("\n-- Eliminando legajo 201 --");
        casoDict.EliminarAlumno(201);
        foreach (var kvp in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo {kvp.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("=== EJEMPLO CON LINQ ===");
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("\n1. Primer libro:");
        Console.WriteLine(casoLinq.GetPrimero().Titulo);

        Console.WriteLine("\n2. Último libro:");
        Console.WriteLine(casoLinq.GetUltimo().Titulo);

        Console.WriteLine("\n3. Suma de todos los precios:");
        Console.WriteLine(casoLinq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\n4. Promedio de precios:");
        Console.WriteLine(casoLinq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n5. Libros con Id > 15:");
        foreach (var l in casoLinq.GetListById())
        {
            Console.WriteLine($"- {l.Id}: {l.Titulo}");
        }

        Console.WriteLine("\n6. Lista de strings (Título - Precio):");
        foreach (var l in casoLinq.GetLibros())
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("\n7. Libro con el precio más alto:");
        Console.WriteLine(casoLinq.GetMayorPrecio().Titulo);

        Console.WriteLine("\n8. Libro con el precio más bajo:");
        Console.WriteLine(casoLinq.GetMenorPrecio().Titulo);

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var l in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"- {l.Titulo} ({l.Precio:C})");
        }

        Console.WriteLine("\n10. Libros ordenados por título de forma descendente (Z-A):");
        foreach (var l in casoLinq.GetLibrosOrdenadosDesc())
        {
            Console.WriteLine($"- {l.Titulo}");
        }
    }
}
