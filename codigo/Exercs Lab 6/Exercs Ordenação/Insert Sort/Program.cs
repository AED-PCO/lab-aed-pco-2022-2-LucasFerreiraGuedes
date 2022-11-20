namespace InsertonSort
{
    class proram
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            preencheVetor(vet);

            Console.WriteLine("Vetro Desordenado: ");
            imprimeVetor(vet);

            Console.WriteLine("Vetor ordenado: ");
            int troca = 0,comparacao=0;
            imprimeVetor(Insert(vet,ref troca,ref comparacao));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Troca: {troca},  Comparação: {comparacao}");
 
        }
        static int[] Insert(int[] vet,ref int troca,ref int comparacao)
        {
            int menor = 0;
 
            for (int i = 1; i <= vet.Length - 1; i++)
            {
                menor = vet[i];
 
                for (int j = i; j >= 1 && vet[j] < vet[j-1] ; j--)
                {
                    comparacao++;
 
                    if (vet[j] < vet[j - 1])
                    {
                        menor = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = menor;
                        troca ++;
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


