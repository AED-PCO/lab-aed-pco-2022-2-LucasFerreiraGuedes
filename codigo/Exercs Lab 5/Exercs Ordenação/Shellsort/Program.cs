using System;


namespace Shellsort
{
    class program
    {
        static void Main()
        {

            int[] vet = new int[10];
            preencheVetor(vet);
            int trocas = 0, comparacao = 0;

            Console.WriteLine("Vetor desordenado: ");
            imprimeVetor(vet);

            Console.WriteLine("Vetor Ordenado: ");
            imprimeVetor(Shellsort(vet,ref trocas,ref comparacao));
            Console.WriteLine();
            Console.WriteLine($"Número de trocas: {trocas}, Número de Comparações: {comparacao}");


        }
        static int[] Shellsort(int[] vet,ref int trocas,ref int comparacao)
        {
            int hop = vet.Length / 2;
            int aux = 0;


            while (hop >= 1)
            {
                for (int i = 0; i + hop <= vet.Length - 1; i++)
                {
                    comparacao++;

                    if (vet[i] > vet[i + hop])
                    {


                        aux = vet[i];
                        vet[i] = vet[i + hop];
                        vet[i + hop] = aux;

                        trocas++;
                        comparacao++;
                        if (i - hop >= 0)
                        {

                            for (int j = vet[i], auxI = i; auxI - hop >= 0; auxI -= hop)
                            {
                                comparacao++;

                                if (j < vet[auxI - hop])
                                {
                                    aux = vet[auxI - hop];
                                    vet[auxI - hop] = j;
                                    vet[auxI] = aux;

                                    trocas++;
                                }

                            }

                        }

                    }

                }

                hop = hop / 2;
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
