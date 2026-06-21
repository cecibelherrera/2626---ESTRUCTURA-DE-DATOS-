namespace AgendaTelefonica
{
    // Registro y estructura
    struct RegistroContacto
    {
        public string Nombre;
        public string Telefono;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de contactos: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            // Vectores
            string[] Contactos = new string[cantidad];
            string[] Telefonos = new string[cantidad];

            // Estructura / Registro
            RegistroContacto[] Registros = new RegistroContacto[cantidad];

            // Ingreso de datos
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("\nContacto " + (i + 1));

                Console.Write("Nombre: ");
                Contactos[i] = Console.ReadLine();

                Console.Write("Telefono: ");
                Telefonos[i] = Console.ReadLine();

                Registros[i].Nombre = Contactos[i];
                Registros[i].Telefono = Telefonos[i];
            }

            int opcion;

            do
            {
                Console.WriteLine("\n===== AGENDA TELEFONICA =====");
                Console.WriteLine("1. Mostrar contactos");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opcion: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        // Matriz
                        string[,] Agenda = new string[cantidad, 2];

                        for (int i = 0; i < cantidad; i++)
                        {
                            Agenda[i, 0] = Registros[i].Nombre;
                            Agenda[i, 1] = Registros[i].Telefono;
                        }

                        Console.WriteLine("\nNOMBRE\t\tTELEFONO");

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(
                                Agenda[i, 0] + "\t\t" +
                                Agenda[i, 1]);
                        }

                        break;

                    case 2:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        break;
                }

            } while (opcion != 2);
        }
    }
}