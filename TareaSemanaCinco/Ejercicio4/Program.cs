// Ejercicio4.cs
using System;
using System.Collections.Generic;

class ListaIntercambio
{
    public List<int> Elementos { get; set; }

    public ListaIntercambio(List<int> elementos)
    {
        Elementos = elementos;
    }

    public void Intercambiar()
    {
        if (Elementos.Count > 1)
        {
            int temp = Elementos[0];
            Elementos[0] = Elementos[^1];
            Elementos[^1] = temp;
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Lista intercambiada:");
        foreach (var e in Elementos)
        {
            Console.Write(e + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ListaIntercambio lista = new ListaIntercambio(new List<int> { 10, 20, 30, 40, 50 });
        lista.Intercambiar();
        lista.Mostrar();
    }
}
