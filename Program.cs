class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese su peso en kg: ");
        double peso = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.Write("Ingrese su altura en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.Write("Ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.Write("Ingrese su género: ");
        string genero = Console.ReadLine() ?? "";

        Console.Write("Ingrese su documento: ");
        string documento = Console.ReadLine() ?? "";

        Console.Write("Ingrese su dirección: ");
        string direccion = Console.ReadLine() ?? "";

        Console.Write("Ingrese su teléfono: ");
        string telefono = Console.ReadLine() ?? "";

        Persona persona = new Persona(nombre, peso, altura, edad, genero, documento, direccion, telefono);

        persona.MostrarInformacion();
    }
}
