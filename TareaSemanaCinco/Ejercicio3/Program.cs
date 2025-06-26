// Ejercicio3.cs
using System;
using System.Collections.Generic;
using System.Linq;

class ListaUnica
{
    public List<int> Numeros { get; set; }

    public ListaUnica(List<int> numeros)
    {
        Numeros = numeros;
    }

    public void EliminarRepetidos()
    {
        Numeros = Numeros.Distinct().ToList();
    }

    public void Mostrar()
    {
        Console.WriteLine("Lista sin duplicados:");
        foreach (var numero in Numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ListaUnica lista = new ListaUnica(new List<int> { 1, 2, 3, 2, 4, 1, 5 });
        lista.EliminarRepetidos();
        lista.Mostrar();
    }
}
