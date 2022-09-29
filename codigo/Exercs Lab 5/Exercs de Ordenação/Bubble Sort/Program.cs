using System;


namespace Bubblersort
{
    class program
    {
        static void Main(string[] args)
        {
            int troca = 0, comparacao = 0;
            int[] vet = new int[] { 23, 16, 4, 42, 8, 15 };

           
            Console.WriteLine("Vetor ordenado: ");
            Bubblersort(vet, ref troca, ref comparacao);
            imprimeVetor(vet);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Número de comparações: {comparacao} ");
            Console.WriteLine($"Número de trocas: {troca}");
           

        }

        static int[] Bubblersort(int[] vet, ref int troca, ref int comparacao)
        {
            int aux = 0;
            int referencia = vet.Length - 1;
            for (int i = 0; i <= referencia; i++)
            {
                if (i == referencia)
                {
                    i = 0;
                    referencia--;
                    //verificação voltada para o final das comparações
                }

                if (vet[i] > vet[i + 1])
                {
                    aux = vet[i + 1];
                    vet[i + 1] = vet[i];
                    vet[i] = aux;
                    troca++;
                    //aqui eu to trocando o valor das variaveis com um aux;

                }
                if (referencia == 0)
                {
                    return vet;
                }
                comparacao += 3;
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

   

