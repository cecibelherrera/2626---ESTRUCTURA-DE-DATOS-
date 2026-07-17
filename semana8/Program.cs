class Program
{
    static void Main(string[] args)
    {
        ColaAsientos sistema = new ColaAsientos();

        int opcion;

        do
        {
            Console.WriteLine("\n--- ATRACCION PARQUE DE DIVERSIONES ---");
            Console.WriteLine("1. Registrar persona");
            Console.WriteLine("2. Asignar asiento");
            Console.WriteLine("3. Mostrar personas en cola");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    sistema.RegistrarPersona();
                    break;


                case 2:
                    sistema.AsignarAsiento();
                    break;


                case 3:
                    sistema.MostrarCola();
                    break;


                case 4:
                    Console.WriteLine("Programa finalizado.");
                    break;


                default:
                    Console.WriteLine("Opcion incorrecta.");
                    break;
            }

        } while (opcion != 4);
    }
}