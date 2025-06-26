// Ejercicio5.cs
using System;
using System.Collections.Generic;
using System.Linq;

class PalabrasFiltradas
{
    public List<string> Palabras { get; set; }

    public PalabrasFiltradas(List<string> palabras)
    {
        Palabras = palabras;
    }

    public void MostrarConLetra(char letra)
    {
        var resultado = Palabras.Where(p => p.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine($"Palabras que empiezan con '{letra}':");
        foreach (var palabra in resultado)
        {
            Console.WriteLine(palabra);
        }
    }
}

class Program
{
    static void Main()
    {
        PalabrasFiltradas lista = new PalabrasFiltradas(new List<string> { "Manzana", "Melón", "Banana", "Mango", "Ciruela" });
        lista.MostrarConLetra('M');
    }
}
