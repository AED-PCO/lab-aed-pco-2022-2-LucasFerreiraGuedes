using System;
 
namespace Exerc_Vet
{
    class Program
    {
        static void Main(string[] args)
        {
            
 
            int[] vetA = new int[5];
            int[] vetB = new int[5];
            int[] vetC = new int[5];
            int[] vetD = new int[5];
 
            LeVetor(vetA);
            LeVetor(vetB);
 
            ElementosEmComum(vetA, vetB, vetC);
 
            DiferencaDeVetores(vetA, vetB, vetD);
 
            EscreveVetor(vetA);
            EscreveVetor(vetB);
            EscreveVetor(vetC);
            EscreveVetor(vetD);
 
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
        static void ElementosEmComum(int[] vetA, int[] vetB,int [] vetC)
        {
            for( int i = 0; i < vetA.Length; i++) { 
            
                for( int j = 0; j < vetB.Length; j++)
                {
                     if (vetA[i] == vetB[j])
                    {
                       vetC[i] = vetA[i];
                    }
                }
            }
        }
        static void DiferencaDeVetores(int[] vetA, int[] vetB, int[] vetD)
        {
            bool aux = false;
            for (int i = 0; i < vetA.Length; i++)
            {
                for (int j = 0; j < vetB.Length; j++)
                {
                    if (vetA[i] == vetB[j])
                    {
                        aux = true;//Console.WriteLine("é igual");
                    }
                    
                }
                if (aux==false)
                    vetD[i] = vetA[i];
            }
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
