using System;

namespace FigurasGeometricas
{
    // Clase que representa un círculo
    public class Circulo
    {
        // Campo privado para almacenar el radio
        private double radio;

        // Propiedad pública para acceder/modificar el radio
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value > 0)
                    radio = value;
                else
                    throw new ArgumentException("El radio debe ser mayor que cero.");
            }
        }

        // Constructor que inicializa el círculo con un radio
        public Circulo(double radio)
        {
            Radio = radio;
        }

        // Método que calcula el área del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método que calcula el perímetro (circunferencia) del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un rectángulo
    public class Rectangulo
    {
        private double baseRect; // Base del rectángulo
        private double altura;   // Altura del rectángulo

        // Propiedad para la base
        public double Base
        {
            get { return baseRect; }
            set
            {
                if (value > 0)
                    baseRect = value;
                else
                    throw new ArgumentException("La base debe ser mayor que cero.");
            }
        }

        // Propiedad para la altura
        public double Altura
        {
            get { return altura; }
            set
            {
                if (value > 0)
                    altura = value;
                else
                    throw new ArgumentException("La altura debe ser mayor que cero.");
            }
        }

        // Constructor que inicializa la base y la altura
        public Rectangulo(double baseRect, double altura)
        {
            Base = baseRect;
            Altura = altura;
        }

        // Método que calcula el área del rectángulo
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // Método que calcula el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }

    // Clase principal para ejecutar el programa
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Crear y probar un círculo
                Circulo circulo = new Circulo(5);
                Console.WriteLine("Círculo:");
                Console.WriteLine($"Área: {circulo.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro():F2}");

                // Crear y probar un rectángulo
                Rectangulo rectangulo = new Rectangulo(4, 7);
                Console.WriteLine("\nRectángulo:");
                Console.WriteLine($"Área: {rectangulo.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {rectangulo.CalcularPerimetro():F2}");
            }
            catch (Exception ex)
            {
                // Captura errores si los valores son inválidos
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

