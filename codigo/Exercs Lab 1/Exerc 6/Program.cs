using System;

namespace Exerc_VI
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número que será a base: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculaElevacao(ref b, ref expoente)); 

        }

        static double CalculaElevacao( ref int b, ref int expoente)
        {
            return Math.Pow(b, expoente);
        }
    }
}