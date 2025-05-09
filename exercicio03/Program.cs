
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a base do retangulo: ");
        double baseRetangulo = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retangulo: ");
        double alturaRetangulo = double.Parse(Console.ReadLine());

        Func<double, double, double> calcularArea = (baseRetangulo, alturaRetangulo) => baseRetangulo * alturaRetangulo;

        double areaRetangulo = calcularArea(baseRetangulo, alturaRetangulo);
        Console.WriteLine($"A área do retângulo é: {areaRetangulo}");
    }
}