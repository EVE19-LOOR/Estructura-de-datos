using System;

namespace RegistroEstudianteApp
{
    // Clase Estudiante
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        // Constructor
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("===== DATOS DEL ESTUDIANTE =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear arreglo de teléfonos
            string[] telefonos = new string[3];

            // Ingreso de datos desde consola
            Console.WriteLine("=== Registro de Estudiante ===");
            Console.Write("Ingrese ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombres: ");
            string nombres = Console.ReadLine();

            Console.Write("Ingrese apellidos: ");
            string apellidos = Console.ReadLine();

            Console.Write("Ingrese dirección: ");
            string direccion = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            // Crear objeto estudiante
            Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);

            // Mostrar datos
            Console.WriteLine();
            estudiante.MostrarInformacion();
        }
    }
}
