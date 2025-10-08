using System;

class Persona
{
    public string Nombre { get; set; }
    public double Peso { get; set; }  
    public double Altura { get; set; } 

    public int Edad { get; set; }
    public string Genero { get; set; }
    public string Documento { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    public Persona(string nombre, double peso, double altura, int edad, string genero, string documento, string direccion, string telefono)
    {
        Nombre = nombre;
        Peso = peso;
        Altura = altura;
        Edad = edad;
        Genero = genero;
        Documento = documento;
        Direccion = direccion;
        Telefono = telefono;
    }

    public double CalcularIMC()
    {
        return Peso / (Altura * Altura);
    }


    public void MostrarInformacion()
    {
        Console.WriteLine("\n====== DATOS DE LA PERSONA =====");
        Console.WriteLine($"su Nombre: {Nombre}");
        Console.WriteLine($"su Edad: {Edad} años");
        Console.WriteLine($"su Género: {Genero}");
        Console.WriteLine($"su Documento: {Documento}");
        Console.WriteLine($"su Dirección: {Direccion}");
        Console.WriteLine($"su Teléfono: {Telefono}");
        Console.WriteLine($"su Peso: {Peso} kg");
        Console.WriteLine($"su Altura: {Altura} m");

        double imc = CalcularIMC();
        Console.WriteLine($"\n-- IMC calculado: {imc:F2}");
    }
}