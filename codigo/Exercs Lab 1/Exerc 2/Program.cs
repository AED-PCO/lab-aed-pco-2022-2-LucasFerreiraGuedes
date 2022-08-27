using System;

namespace Exerc_II
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número a ser verificado para saber se ele é ou não primo: ");
            int num = int.Parse(Console.ReadLine());
            
            if(VerificaPrimo(num) == false)
            {
                Console.WriteLine($"O {num} não é um número primo ");
            }
            else
            {
                Console.WriteLine($"O {num} é um número primo ");
            }
            Console.WriteLine();

            Console.WriteLine("Os números que são perfeitos entre no intervalo de 1 a 1000: ");
            VerificanumerosPerfeitos();

        }
        static bool VerificaPrimo(int num)
        {
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;

                    //não é primo
                }
            }
            return true;

        }
        static void VerificanumerosPerfeitos()
        {
            int num = 1;
            int soma = 0;
            Console.WriteLine();

            for (int i = 1; i < 1000; i++)
            {
                // "travar" em cada valor e testar

                for(num = 1; num < i; num++)
                {
                    if (i % num == 0)
                    {
                        soma += num;
                        // somando seus divisores
                    }
                }
                if (soma == i)
                {
                    Console.WriteLine($"O {num} é um número perfeito");
                }
                soma = 0;
            }
               
        }
       
    }
}