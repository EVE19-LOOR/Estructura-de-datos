// Ejercicio2.cs
using System;
using System.Collections.Generic;

class Estudiante
{
    public Dictionary<string, float> Notas { get; set; }

    public Estudiante()
    {
        Notas = new Dictionary<string, float>
        {
            {"Matemáticas", 8.5f},
            {"Física", 7.0f},
            {"Química", 9.0f},
            {"Historia", 6.5f},
            {"Lengua", 7.8f}
        };
    }

    public void MostrarNotas()
    {
        Console.WriteLine("Notas del estudiante:");
        foreach (var asignatura in Notas)
        {
            Console.WriteLine($"{asignatura.Key}: {asignatura.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante();
        estudiante.MostrarNotas();
    }
}

