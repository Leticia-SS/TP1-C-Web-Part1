using System;

public class Program
{
    public delegate void WelcomeMessage(string name);

    public static void Main(string[] args)
    {
        WelcomeMessage mensagem;

        Console.WriteLine("Escolha o idioma:");
        Console.WriteLine("1 - Português");
        Console.WriteLine("2 - English");
        Console.WriteLine("3 - Español");

        byte opcao = byte.Parse(Console.ReadLine());

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        switch(opcao)
        {
            case 1:
                mensagem = MensagemPortugues;
                break;
            case 2:
                mensagem = MensagemIngles;
                break;
            case 3:
                mensagem = MensagemEspanhol;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        mensagem(nome);
    }

    static void MensagemPortugues(string nome)
    {
        Console.WriteLine($"Bem-vindo, {nome}!");
    }

    static void MensagemIngles(string nome)
    {
        Console.WriteLine($"Welcome, {nome}!");
    }

    static void MensagemEspanhol(string nome)
    {
        Console.WriteLine($"¡Bienvenido, {nome}!");
    }
}