

namespace InsertoSort
{
    class proram
    {
        static void Main(string[] args)
        {
            int[] vet = new int[] { 23, 16, 4, 42, 8, 15 };
            imprimeVetor(Insert(vet));

        }
        static int [] Insert(int[] vet)
        {
            int menor = 0;

            for (int i = 1 ; i <= vet.Length-1; i++)
            {
                menor = vet[i];

                for (int j = i;j >= 1; j--)
                    {
                    if (vet[j] < vet[j - 1])
                    {
                        menor = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = menor;
                    }
                    
                    }
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