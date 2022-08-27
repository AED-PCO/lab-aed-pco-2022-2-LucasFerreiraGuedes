using System;

namespace Soma_Recursividade
{
    class program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros a serem multiplicados: ");
            int a = int.Parse(Console.ReadLine());
            int multiplicador = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiplicacao(a, multiplicador));
        }
        
        static int Multiplicacao(int a, int multiplicador)
        {
            
            if (multiplicador == 1)
            {
                return a;
            }
            else
            {
                return a + Multiplicacao(a,multiplicador-1);
            }

            

        }
    }
}