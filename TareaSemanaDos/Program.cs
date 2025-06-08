/*
 * Nombre: [Tu Nombre Aquí]
 * Fecha: 07 de Junio de 2025
 * Número de Hoja: 1
 * 
 * Programa: Clases de Figuras Geométricas
 * Descripción: Implementación de clases Circulo y Rectangulo con encapsulación
 * de tipos de datos primitivos y métodos para calcular área y perímetro.
 */

using System;

namespace FigurasGeometricas
{
    // Clase Circulo - Encapsula las propiedades de un círculo
    public class Circulo
    {
        // Campo privado para encapsular el tipo de dato primitivo (double)
        private double radio;

        // Constructor que inicializa el radio del círculo
        // Parámetro: radio - valor double que representa el radio del círculo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Propiedad pública para acceder y modificar el radio de forma controlada
        // Encapsula el tipo de dato primitivo double
        public double Radio
        {
            get { return radio; }
            set 
            { 
                // Validación para asegurar que el radio sea positivo
                if (value > 0)
                    radio = value;
                else
                    throw new ArgumentException("El radio debe ser mayor que cero");
            }
        }

        // CalcularArea es una función que devuelve un valor double, se utiliza para 
        // calcular el área de un círculo, requiere como argumento el radio del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para
        // calcular el perímetro (circunferencia) de un círculo usando la fórmula 2πr
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        // Método ToString para mostrar información del círculo de forma legible
        public override string ToString()
        {
            return $"Círculo con radio: {radio:F2}";
        }
    }

    // Clase Rectangulo - Encapsula las propiedades de un rectángulo
    public class Rectangulo
    {
        // Campos privados para encapsular los tipos de datos primitivos (double)
        private double ancho;
        private double alto;

        // Constructor que inicializa las dimensiones del rectángulo
        // Parámetros: ancho y alto - valores double que representan las dimensiones
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // Propiedad pública para acceder y modificar el ancho de forma controlada
        // Encapsula el tipo de dato primitivo double
        public double Ancho
        {
            get { return ancho; }
            set 
            { 
                // Validación para asegurar que el ancho sea positivo
                if (value > 0)
                    ancho = value;
                else
                    throw new ArgumentException("El ancho debe ser mayor que cero");
            }
        }

        // Propiedad pública para acceder y modificar el alto de forma controlada
        // Encapsula el tipo de dato primitivo double
        public double Alto
        {
            get { return alto; }
            set 
            { 
                // Validación para asegurar que el alto sea positivo
                if (value > 0)
                    alto = value;
                else
                    throw new ArgumentException("El alto debe ser mayor que cero");
            }
        }

        // CalcularArea es una función que devuelve un valor double, se utiliza para
        // calcular el área de un rectángulo multiplicando ancho por alto
        public double CalcularArea()
        {
            return ancho * alto;
        }

        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para
        // calcular el perímetro de un rectángulo usando la fórmula 2(ancho + alto)
        public double CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }

        // Método ToString para mostrar información del rectángulo de forma legible
        public override string ToString()
        {
            return $"Rectángulo con ancho: {ancho:F2} y alto: {alto:F2}";
        }
    }

    // Clase principal para demostrar el uso de las figuras geométricas
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO: Figuras Geométricas ===\n");

            try
            {
                // Crear instancia de Círculo
                // Encapsula el tipo de dato primitivo double para el radio
                Circulo miCirculo = new Circulo(5.0);
                
                Console.WriteLine(miCirculo.ToString());
                Console.WriteLine($"Área: {miCirculo.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {miCirculo.CalcularPerimetro():F2}");
                Console.WriteLine();

                // Crear instancia de Rectángulo
                // Encapsula los tipos de datos primitivos double para ancho y alto
                Rectangulo miRectangulo = new Rectangulo(4.0, 6.0);
                
                Console.WriteLine(miRectangulo.ToString());
                Console.WriteLine($"Área: {miRectangulo.CalcularArea():F2}");
                Console.WriteLine($"Perímetro: {miRectangulo.CalcularPerimetro():F2}");
                Console.WriteLine();

                // Demostrar modificación de propiedades encapsuladas
                Console.WriteLine("=== Modificando propiedades ===");
                miCirculo.Radio = 7.5;
                miRectangulo.Ancho = 3.0;
                miRectangulo.Alto = 8.0;

                Console.WriteLine($"Círculo modificado - Nueva área: {miCirculo.CalcularArea():F2}");
                Console.WriteLine($"Rectángulo modificado - Nueva área: {miRectangulo.CalcularArea():F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}