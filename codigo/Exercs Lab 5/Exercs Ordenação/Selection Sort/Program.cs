using System;
 
namespace SelectSort
{
    class program
    {
        static void Main(string[] args)
        {
            int[] vet = new int [10];
            preencheVetor(vet);
            Console.WriteLine("Vetor desordenado: ");
            imprimeVetor(vet);
            int trocas = 0, comparacao = 0;
            Console.WriteLine("Vetor ordenado: ");
            imprimeVetor(SelectSort(vet,ref trocas,ref comparacao));
            Console.WriteLine($"Número de trocas: {trocas}, Número de Comparações: {comparacao}");

       
        }
        static int[] SelectSort (int[] vet,ref int trocas,ref int comparacao)
        {
 
            int menor = vet[0],posicaoMenor = 0, aux = 0;
           
           
 
            for(int i = 0; i < vet.Length-1; i++)
            {
                for(int j = i;j < vet.Length-1; j++)
                {
                   comparacao++;
                    if (vet[j+1] < menor)
                    {
                        menor = vet[j+1];
                        posicaoMenor = j+1;
                       
                    }
                    else if(i+1 == vet.Length-1){
                       return vet;
                    }
                   
                }
                aux = vet[i];
                vet[i] = menor;
                vet[posicaoMenor] = aux;
                menor = vet[i+1];
                
                trocas++;
               
            }
            return vet;
        }
        static void imprimeVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("\t" + vet[i]);
            }
            Console.WriteLine();
        }
        static void preencheVetor(int[] vet)
        {
            Random randNum = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = randNum.Next(10);
            }
        }

 
    }
}
