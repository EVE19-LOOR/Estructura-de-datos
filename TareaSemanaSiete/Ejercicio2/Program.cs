using System;
using System.Collections.Generic;

class TorreDeHanoi
{
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nomOrigen, string nomDestino, string nomAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nomOrigen} a {nomDestino}");
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino, nomOrigen, nomAuxiliar, nomDestino);
            MoverDiscos(1, origen, destino, auxiliar, nomOrigen, nomDestino, nomAuxiliar);
            MoverDiscos(n - 1, auxiliar, destino, origen, nomAuxiliar, nomDestino, nomOrigen);
        }
    }

    static void Main()
    {
        int numDiscos = 3;
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("Movimientos para resolver las Torres de Hanoi:");
        MoverDiscos(numDiscos, torreA, torreC, torreB, "A", "C", "B");
    }
}
