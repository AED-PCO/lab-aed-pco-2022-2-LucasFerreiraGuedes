using System;

namespace Soma_Recursividade
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número que será a base da potenciação: ");
            int basee = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número que será o expoente da potenciação: ");
            int expoente = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da Potenciação é: {Potenciacao(basee, expoente)}");
      
        }
        static double Potenciacao(int basee, int expoente)
        {
            if(expoente == 1)
            {
                return basee;
            }
            else
            {
                return basee * Potenciacao(basee, expoente - 1);
            }
        }
    }

}