using System;
 
namespace Exerc_Recursivo
{
    class program
    {
        static void Main(string[] args)
        {
 
            int[] vet = { 2, 2, 3, 10, 20, 50 };
            Console.WriteLine(CalculaVetPar(vet, vet.Length - 1));
 
        }
 
        static int CalculaVetPar(int[] Vet, int posicao)
        {
 
            
            
            if (posicao == -1)
            {
                return 0;
 
            }
            if (Vet[posicao] %2 == 0)
            {
                 return Vet[posicao] + CalculaVetPar(Vet, posicao - 1);
 
            }
            return CalculaVetPar(Vet,posicao - 1);
        }
    }
}
