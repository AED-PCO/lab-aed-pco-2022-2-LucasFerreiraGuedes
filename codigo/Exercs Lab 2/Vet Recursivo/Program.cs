using System;
 
namespace Exerc_Recursivo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho que deverá ser criado o vetor");
            int tamVet = int.Parse(Console.ReadLine());
            int[] vet = new int [tamVet];

            LeVetor(vet);

            Console.WriteLine("O vetor escrito foi:");
            EscreveVetor(vet);


            Console.WriteLine("A soma dos elementos pares do Vetor é:");
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
         static void LeVetor(int[] vet)
        { 
 
            for(int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Digite um valor para ser alocado no vetor");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
        static void EscreveVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + "\t");
            }
            Console.WriteLine();
        }


    }
}

