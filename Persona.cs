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

 public string ClasificarIMC()
    {
        double imc = CalcularIMC();
        if (imc < 18.5)
            return "Bajo peso - Riesgo: deficiencias nutricionales, anemia, osteoporosis.";
        else if (imc >= 18.5 && imc <= 24.9)
            return "Normal - Riesgo: bajo, estado saludable.";
        else if (imc >= 25 && imc <= 29.9)
            return "Sobrepeso - Riesgo: aumentado (cardiovasculares, hipertensión, diabetes).";
        else if (imc >= 30 && imc <= 34.9)
            return "Obesidad Tipo I - Riesgo: alto (diabetes tipo 2, hipertensión, cardiovasculares).";
        else if (imc >= 35 && imc <= 39.9)
            return "Obesidad Tipo II - Riesgo: muy alto (infartos, apnea del sueño, artrosis).";
        else
            return "Obesidad Tipo III - Riesgo: extremadamente alto (cardiovasculares, metabólicas, mortalidad).";
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
        Console.WriteLine($"-- Clasificación: {ClasificarIMC()}");
    }
}