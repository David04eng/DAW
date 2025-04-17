using System;

public class ImcCalculator
{
    public double Peso { get; set; }
    public double Altura { get; set; }

    public double CalcularIMC()
    {
        if (Peso <= 0 || Altura <= 0)
        {
            throw new ArgumentException("Peso y altura deben ser mayores que cero.");
        }

        return Peso / (Altura * Altura);
    }

    public string ClasificarIMC(double imc)
    {
        if (imc < 18.5) return "Bajo peso";
        if (imc < 24.9) return "Normal";
        if (imc < 29.9) return "Sobrepeso";
        return "Obesidad";
    }

    public static void Main(string[] args)
    {
        try
        {
            ImcCalculator imcCalculator = new ImcCalculator();

            // Obtener peso y altura desde el usuario
            Console.Write("Ingrese el peso (kg): ");
            imcCalculator.Peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura en formato con punto decimal (m): ");
            imcCalculator.Altura = Convert.ToDouble(Console.ReadLine());

            // Calcular IMC
            double imc = imcCalculator.CalcularIMC();
            Console.WriteLine($"Tu IMC es: {imc:F2}");

            // Clasificar IMC
            string clasificacion = imcCalculator.ClasificarIMC(imc);
            Console.WriteLine($"Clasificación: {clasificacion}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
