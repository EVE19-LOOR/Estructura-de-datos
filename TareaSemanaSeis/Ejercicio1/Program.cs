// Definición del nodo
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

// Definición de la lista enlazada
public class ListaEnlazada
{
    public Nodo Cabeza;

    public void AgregarAlFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
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

    public void Invertir()
    {
        Nodo anterior = null, actual = Cabeza, siguiente = null;
        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }
        Cabeza = anterior;
    }

    public void Imprimir()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}

// Ejemplo de uso
class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.AgregarAlFinal(1);
        lista.AgregarAlFinal(2);
        lista.AgregarAlFinal(3);
        lista.AgregarAlFinal(4);

        Console.WriteLine("Lista original:");
        lista.Imprimir();

        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Imprimir();
    }
}

