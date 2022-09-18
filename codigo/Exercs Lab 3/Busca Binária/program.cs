using System;

namespace BuscaBinaria
{
    class program
    {
        static void Main(string[] args)
        {

            int[] vet = { 57, 8, 15, 42, 4, 23, 16, 61, 92 };
            Array.Sort(vet);

            Console.WriteLine("Digite um número que deseja buscar no vetor e saber qual é a sua posição: ");
            int num = int.Parse(Console.ReadLine());

            if (BuscaBinaria(vet, num) == -1)
            {
                Console.WriteLine("O número não está contido no vetor");
            }
            else
            {
                Console.WriteLine(BuscaBinaria(vet, num));
            }

        }

        static int BuscaBinaria(int[] vet, int num)
        {
            int inicio = 0;
            int final = vet.Length -1;

            while (inicio <= final)
            {

                int meio = (inicio + final) / 2;

                if (vet[meio] == num)
                {
                    return meio;
                }
                else if (vet[meio] > num)
                {
                    final = meio - 1;
                }
                else if (vet[meio] < num)
                {
                    inicio = meio + 1;
                }
                
            }
            return -1;


        }



    }
}