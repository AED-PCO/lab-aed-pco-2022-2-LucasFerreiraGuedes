using System;

namespace SelectSort
{
    class program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[] { 23, 16, 4, 42, 15, 8 };

            imprimeVetor(SelectSort(vet));

        }
        static int[] SelectSort(int[] vet)
        {

            int menor = vet[0], posicaoMenor = 0, aux = 0;



            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = i; j < vet.Length - 1; j++)
                {

                    if (vet[j + 1] < menor)
                    {
                        menor = vet[j + 1];
                        posicaoMenor = j + 1;

                    }
                    else if (i + 1 == vet.Length - 1)
                    {
                        return vet;
                    }

                }
                aux = vet[i];
                vet[i] = menor;
                vet[posicaoMenor] = aux;
                menor = vet[i + 1];

            }
            return vet;
        }
        static void imprimeVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("\t" + vet[i]);
            }
        }

    }
}