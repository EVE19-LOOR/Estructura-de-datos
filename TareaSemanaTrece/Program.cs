// ==========================================================
// Proyecto: Catálogo de Revistas
// Autor: Evelin Loor
// Universidad Estatal Amazónica
// Fecha: Septiembre 2025
// Descripción:
// Aplicación en C# que permite gestionar un catálogo de revistas
// y realizar búsquedas mediante un algoritmo recursivo.
// Se incluyen funcionalidades extra: agregar revistas y estadísticas.
// ==========================================================

using System;
using System.Collections.Generic;

class CatalogoRevistas
{
    // Lista que almacena los títulos de las revistas
    static List<string> revistas = new List<string>()
    {
        "National Geographic",
        "Time",
        "Forbes",
        "Nature",
        "Scientific American",
        "The Economist",
        "PC World",
        "Wired",
        "Reader's Digest",
        "Sports Illustrated"
    };

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== Catálogo de Revistas =====");
            Console.WriteLine("1. Buscar revista");
            Console.WriteLine("2. Mostrar catálogo");
            Console.WriteLine("3. Agregar revista");
            Console.WriteLine("4. Mostrar estadísticas");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    BuscarRevista();
                    break;
                case 2:
                    MostrarCatalogo();
                    break;
                case 3:
                    AgregarRevista();
                    break;
                case 4:
                    MostrarEstadisticas();
                    break;
                case 5:
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                    break;
            }

            if (opcion != 5)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);
    }

    // Método para buscar revista (búsqueda recursiva)
    static void BuscarRevista()
    {
        Console.Write("\nIngrese el título de la revista a buscar: ");
        string titulo = Console.ReadLine();

        bool encontrado = BuscarRecursivo(revistas, titulo, 0);

        if (encontrado)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n'{titulo}' → Encontrado");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n'{titulo}' → No encontrado");
        }
        Console.ResetColor();
    }

    // Algoritmo de búsqueda recursiva
    static bool BuscarRecursivo(List<string> lista, string titulo, int indice)
    {
        if (indice >= lista.Count) // Caso base: llegamos al final de la lista
            return false;

        if (lista[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
            return true;

        // Llamada recursiva al siguiente elemento
        return BuscarRecursivo(lista, titulo, indice + 1);
    }

    // Método para mostrar todas las revistas
    static void MostrarCatalogo()
    {
        Console.WriteLine("\n===== Lista de Revistas =====");
        foreach (string revista in revistas)
        {
            Console.WriteLine("- " + revista);
        }
    }

    // Método para agregar nueva revista al catálogo
    static void AgregarRevista()
    {
        Console.Write("\nIngrese el título de la nueva revista: ");
        string nuevaRevista = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nuevaRevista))
        {
            revistas.Add(nuevaRevista);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n'{nuevaRevista}' fue agregada exitosamente al catálogo.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNo se puede agregar un título vacío.");
            Console.ResetColor();
        }
    }

    // Método para mostrar estadísticas del catálogo
    static void MostrarEstadisticas()
    {
        Console.WriteLine("\n===== Estadísticas del Catálogo =====");
        Console.WriteLine($"Cantidad total de revistas: {revistas.Count}");
    }
}
