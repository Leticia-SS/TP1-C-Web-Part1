using System;
using exercicio06.Logger;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();
        Action<string> logDelegate = null;

        while (true)
        {
            Console.WriteLine("\n=== MENU PRINCIPAL ===");
            Console.WriteLine("1. Configurar logs");
            Console.WriteLine("2. Enviar mensagem para log");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n=== CONFIGURAR LOGS ===");
                    Console.WriteLine("1. Adicionar todos os logs");
                    Console.WriteLine("2. Remover todos os logs");
                    Console.Write("Escolha: ");

                    if (int.TryParse(Console.ReadLine(), out int logChoice))
                    {
                        if (logChoice == 1)
                        {
                            logDelegate = logger.LogToConsole;
                            logDelegate += logger.LogToFile;
                            logDelegate += logger.LogToDatabase;
                            Console.WriteLine("Todos os métodos de log foram adicionados.");
                        }
                        else
                        {
                            logDelegate = null;
                            Console.WriteLine("Todos os métodos de log foram removidos.");
                        }
                    }
                    break;

                case 2:
                    Console.Write("\nDigite a mensagem para logar: ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        logDelegate?.Invoke(input);
                        Console.WriteLine("Mensagem processada.");
                    }
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}