using System;

class Program
{
    static void Main()
    {
        Func<string, string, string> formatador = (nome, sobrenome) =>
        {
            var resultado = nome + " " + sobrenome;
            Console.WriteLine("Após concatenar: " + resultado);
            return resultado;
        };

        formatador += (nomeCompleto, _) =>
        {
            var resultado = nomeCompleto.ToUpper();
            Console.WriteLine("Após converter para maiúsculas: " + resultado);
            return resultado;
        };

        formatador += (nomeCompleto, _) =>
        {
            var resultado = nomeCompleto.Replace(" ", "");
            Console.WriteLine("Após remover espaços: " + resultado);
            return resultado;
        };

        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o sobrenome:");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("\nProcessamento:");
        string resultadoFinal = formatador(nome, sobrenome);

        Console.WriteLine("\nResultado final: " + resultadoFinal);
    }
}