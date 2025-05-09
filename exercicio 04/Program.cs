using System;
using exercicio_04;

public class Program
{
    public static void Main(string[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();

        sensor.temperatureExceeded += (sender, message) =>
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        };

        while (true)
        {
            Console.Write("Digite a temperatura atual (ou 'sair' para encerrar): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
                break;

            if (double.TryParse(input, out double temperature))
            {
                sensor.SetTemperature(temperature);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número ou 'sair'.");
            }
        }
    }
}

