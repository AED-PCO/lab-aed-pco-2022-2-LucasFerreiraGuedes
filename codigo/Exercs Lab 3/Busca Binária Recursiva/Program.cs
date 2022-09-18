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

            if (BuscaBinaria(vet, num,0,vet.Length-1) == -1)
            {
                Console.WriteLine("O número não está contido no vetor");
            }
            else
            {
                Console.WriteLine(BuscaBinaria(vet, num,0,vet.Length-1));
            }

        }

        static int BuscaBinaria(int[] vet, int num,int ini,int finish)
        {
            
            
           int meio = (ini + finish) / 2;

            if (ini == finish)
            {
                if (vet[meio] == num)
                {
                    return meio;
                }
                return -1;
            }

                if (vet[meio] == num)
                {
                    return meio;
                }
                else if (vet[meio] > num)
                {
                return BuscaBinaria(vet, num, 0, finish = meio-1);
                }
                else if (vet[meio] < num)
                {
                    return BuscaBinaria(vet,num, ini = meio + 1,finish) ;
                }
            return -1;

        }



    }
}