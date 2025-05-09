using System;

public delegate decimal CalculateDiscount(decimal valor);
public class Program
{
    public static void Main(string[] args)
    {

        static decimal Discount10(decimal valor)
        {
            return valor * 0.10m;
        }

        Console.WriteLine("Digite o valor do produto: ");
        decimal preco = decimal.Parse(Console.ReadLine());

        CalculateDiscount desconto = Discount10;

        decimal valorComDesconto = preco - desconto(preco);

        Console.WriteLine($"O valor do produto sem desconto é: {preco:C}");
        Console.WriteLine($"O valor do produto com desconto é: {valorComDesconto:C}");
        Console.WriteLine($"O valor do desconto é: {desconto(preco):C}");


    }
}