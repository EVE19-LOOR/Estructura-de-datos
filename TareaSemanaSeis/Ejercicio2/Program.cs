using System;

public class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    public Nodo Cabeza;

    public void AgregarAlFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (Cabeza == null)
        {
            Cabeza = nuevo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }
    }

    public void Imprimir()
    {
        Nodo actual = Cabeza;
        Console.WriteLine("Elementos de la lista:");
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    public int Buscar(int valor)
    {
        int contador = 0;
        Nodo actual = Cabeza;
        while (actual != null)
        {
            if (actual.Dato == valor)
                contador++;
            actual = actual.Siguiente;
        }
        if (contador == 0)
            Console.WriteLine("El dato no fue encontrado.");
        else
            Console.WriteLine($"El dato {valor} se encontró {contador} veces.");
        return contador;
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.AgregarAlFinal(5);
        lista.AgregarAlFinal(3);
        lista.AgregarAlFinal(5);
        lista.AgregarAlFinal(7);

        lista.Imprimir();

        lista.Buscar(5); // Debería indicar que se encontró 2 veces
        lista.Buscar(8); // Debería indicar que no fue encontrado
    }
}