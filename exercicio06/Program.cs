using System;
using exercicio06;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();

        Action<string> logToConsole = logger.LogToConsole;

        logToConsole += logger.LogToFile;
        logToConsole += logger.LogToDatabase;

        while (true)
        {
            Console.Write("Digite uma mensagem para logar (ou 'sair' para encerrar): ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "sair")
            {
                break;
            }
            
            logToConsole(input);
            Console.WriteLine("Todos os logs foram processados.\n");
        }
    }
}