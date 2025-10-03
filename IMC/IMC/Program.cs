using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   Calculadora de Índice de Masa Corporal (IMC)");
        Console.WriteLine("=====================================");

        // 1. Solicitar Peso
        double peso = LeerEntrada("Ingrese su peso en kilogramos (ej: 75.5): ");

        // 2. Solicitar Estatura
        double estatura = LeerEntrada("Ingrese su estatura en metros (ej: 1.70): ");

        // 3. Calcular IMC
        double imc = peso / (estatura * estatura);

        // 4. Determinar Estado Nutricional
        string estadoNutricional;
        if (imc < 18.5)
            estadoNutricional = "Peso bajo";
        else if (imc < 25.0)
            estadoNutricional = "Peso normal";
        else if (imc < 30.0)
            estadoNutricional = "Sobrepeso";
        else if (imc < 40.0)
            estadoNutricional = "Obesidad";
        else
            estadoNutricional = "Obesidad extrema";

        // 5. Mostrar Resultados
        Console.WriteLine("\n-- Resultados --");
        Console.WriteLine($"Peso: {peso:F2} kg");
        Console.WriteLine($"Estatura: {estatura:F2} m");
        Console.WriteLine($"Índice de Masa Corporal (IMC): {imc:F2} kg/m²");
        Console.WriteLine($"Estado Nutricional: {estadoNutricional}");
        Console.WriteLine("-----------------\n");
    }

    // Método para validar y leer entrada numérica positiva
    static double LeerEntrada(string mensaje)
    {
        double valor;
        string entrada;

        Console.Write(mensaje);
        entrada = Console.ReadLine();

        while (!double.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) || valor <= 0)
        {
            Console.WriteLine("⚠️ Error: Ingresaste un valor no válido.");
            Console.Write(mensaje);
            entrada = Console.ReadLine();
        }

        return valor;
    }
}
