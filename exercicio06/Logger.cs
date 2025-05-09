using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06.Logger
{
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[CONSOLE] {DateTime.Now}: {message}");
            Console.ResetColor();
        }

        public void LogToFile(string message)
        {
            string logEntry = $"[FILE] {DateTime.Now}: {message}";
            File.AppendAllText("app.log", logEntry + Environment.NewLine);
            Console.WriteLine($"Log gravado em arquivo: app.log");
        }

        public void LogToDatabase(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[DATABASE] {DateTime.Now}: Registro simulado no BD - {message}");
            Console.ResetColor();
        }
    }
}
