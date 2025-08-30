using System;
using System.Collections.Generic;
using System.Linq;

class Traductor
{
    static void Main()
    {
        // Diccionario inicial (Inglés ↔ Español)
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        int opcion;

        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;
                case 2:
                    AgregarPalabra(diccionario);
                    break;
                case 0:
                    Console.WriteLine("¡Saliendo del programa!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la frase a traducir: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');

        for (int i = 0; i < palabras.Length; i++)
        {
            // Quitar signos de puntuación
            string palabraLimpia = palabras[i].Trim(new char[] { '.', ',', ';', ':', '!', '?' });

            string traducida = null;

            // Traducir inglés → español
            if (diccionario.ContainsKey(palabraLimpia))
                traducida = diccionario[palabraLimpia];
            // Traducir español → inglés
            else if (diccionario.ContainsValue(palabraLimpia))
                traducida = diccionario.FirstOrDefault(x => x.Value.Equals(palabraLimpia, StringComparison.OrdinalIgnoreCase)).Key;

            if (traducida != null)
            {
                // Mantener mayúscula inicial si la original la tenía
                if (char.IsUpper(palabras[i][0]))
                    traducida = char.ToUpper(traducida[0]) + traducida.Substring(1);

                // Reemplazar palabra en la frase
                palabras[i] = palabras[i].Replace(palabraLimpia, traducida);
            }
        }

        string traduccion = string.Join(" ", palabras);
        Console.WriteLine("Traducción parcial: " + traduccion);
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().Trim();

        Console.Write("Ingrese la traducción al español: ");
        string espanol = Console.ReadLine().Trim();

        if (diccionario.ContainsKey(ingles))
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
        else
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine($"Palabra '{ingles}' agregada correctamente con traducción '{espanol}'.");
        }
    }
}
