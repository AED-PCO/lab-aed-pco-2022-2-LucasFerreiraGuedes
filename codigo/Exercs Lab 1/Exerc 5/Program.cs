using System;

namespace Exerc_V
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número em que se deseja calcular o seu fatorial: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculaFat(num)); 
        }
        static int CalculaFat(int num)
        {
            int fat = num;
            for (int i = num - 1; i > 0; i--)
            {
                fat *= num - i;
            }
            return fat;
        }
    }
}