class ColaAsientos
{
    Queue<Persona> cola = new Queue<Persona>();


    public void RegistrarPersona()
    {
        if (cola.Count < 30)
        {
            Console.Write("Ingrese nombre de la persona: ");
            string nombre = Console.ReadLine();

            Persona persona = new Persona(nombre);

            cola.Enqueue(persona);

            Console.WriteLine("Persona registrada correctamente.");
        }
        else
        {
            Console.WriteLine("Todos los asientos fueron vendidos.");
        }
    }


    public void AsignarAsiento()
    {
        if (cola.Count > 0)
        {
            Persona persona = cola.Dequeue();

            Console.WriteLine("Asiento asignado a: " + persona.Nombre);
        }
        else
        {
            Console.WriteLine("No existen personas en espera.");
        }
    }


    public void MostrarCola()
    {
        if (cola.Count > 0)
        {
            Console.WriteLine("\nPersonas en espera:");

            foreach (Persona persona in cola)
            {
                Console.WriteLine(persona.Nombre);
            }
        }
        else
        {
            Console.WriteLine("La cola está vacía.");
        }
    }
}