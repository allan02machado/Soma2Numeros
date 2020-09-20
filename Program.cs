using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;

            Console.WriteLine("Bem-vindo ao calcula soma");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Digite os valores a serem somados: ");

            Console.Write("1o. numero: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("2o. numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            int resultado = primeiroNumero + segundoNumero;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ResetColor();
        }
    }
}
