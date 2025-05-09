using System;
using exercicio05;

public class Program
{
    public static void Main(string[] args)
    {
        DowloadManager dowloadManager = new DowloadManager();

        dowloadManager.downloadCompleted += (sender, message) =>
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine("Notificação: O download foi concluído e está pronto para uso.");
        };

        Console.Write("Digite o nome do arquivo para download: ");
        string file = Console.ReadLine();

        Console.Write("Digite o tempo de simulação (segundos): ");
        
        if (int.TryParse(Console.ReadLine(), out int seconds))
        {
            new Thread(() =>
            {
                dowloadManager.StartDownload(file, seconds);
            }).Start();

            Console.WriteLine("O download está em progresso... Você pode continuar usando o sistema.");
        }
        else
        {
            Console.WriteLine("Tempo inválido. Use apenas números inteiros.");
        }
    }
}