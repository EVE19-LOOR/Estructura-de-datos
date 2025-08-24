using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main(string[] args)
    {
        // 1. Crear conjunto de 500 ciudadanos
        HashSet<string> todosCiudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            todosCiudadanos.Add($"Ciudadano {i}");
        }

        // 2. Crear conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add($"Ciudadano {i}");
        }

        // 3. Crear conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++) // solapados entre 50 y 75
        {
            astrazeneca.Add($"Ciudadano {i}");
        }

        // 4. Operaciones de teoría de conjuntos
        HashSet<string> noVacunados = new HashSet<string>(todosCiudadanos);
        noVacunados.ExceptWith(pfizer.Union(astrazeneca));

        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        HashSet<string> soloAstra = new HashSet<string>(astrazeneca);
        soloAstra.ExceptWith(pfizer);

        // 5. Mostrar resultados ordenados
        MostrarResultados("Ciudadanos NO vacunados", noVacunados);
        MostrarResultados("Ciudadanos con ambas dosis", ambasDosis);
        MostrarResultados("Ciudadanos SOLO Pfizer", soloPfizer);
        MostrarResultados("Ciudadanos SOLO AstraZeneca", soloAstra);
    }

    // Método para mostrar de forma clara
    static void MostrarResultados(string titulo, HashSet<string> conjunto)
    {
        Console.WriteLine($"\n=== {titulo} ===");
        Console.WriteLine($"Total: {conjunto.Count}\n");

        foreach (var ciudadano in conjunto.OrderBy(c => c))
        {
            Console.WriteLine(ciudadano);
        }
    }
}
