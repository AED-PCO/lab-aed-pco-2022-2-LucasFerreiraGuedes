using System;



namespace ContagemVet
{
    class program
    {
        static void Main(string[] args)
        {
            int[] vetBase = new int[10];
            int[] vetCont = new int[vetBase.Length];
            int menor = 10000;
            int maior = 0;
            int trocas = 0;
            int comparacao = 0;

            preencheVetor(vetBase);
            Console.WriteLine("Vetor Base Desordenado: ");
            imprimeVetor(vetBase);
            Console.WriteLine();

            Console.WriteLine("Vetor com a Contagem de Repetição de Cada Termo");
            vetCont= (Contagem(vetBase, vetCont, ref menor, ref maior,ref trocas,ref comparacao));
            imprimeVetor(vetCont);
            Console.WriteLine();

            Console.WriteLine("Tabela de repetição Ordenada");
            int[] vetTabela = (Tabela(ref menor, ref maior, vetBase, vetCont));
            imprimeVetor(vetTabela);
            imprimeVetor(OrdenaVetor(vetBase, vetTabela));
           
           Console.WriteLine();
           Console.WriteLine($"Número de Trocas: {trocas}, Número de Comparações: {comparacao}");
            
            
        }


        static int[] Contagem(int[] vetBase, int[] vetCont, ref int menor, ref int maior, ref int trocas,ref int comparacao)
        {
            int repeticao = 0;

            for (int i = 0; i < vetBase.Length; i++)
            {
                comparacao++;

                if (vetBase[i] > maior)
                {
                    maior = vetBase[i];
                    trocas++;
                }
                else if (vetBase[i] < menor)
                {
                    menor = vetBase[i];
                    trocas++;
                }

                for (int j = 0; j < vetBase.Length ; j++)
                {
                    comparacao++;

                    if (vetBase[i] == vetBase[j])
                    {
                        repeticao++;
                    }
                }
                vetCont[i] = repeticao;
                repeticao = 0;

            }
            return vetCont;
        }
        static int[] Tabela(ref int menor, ref int maior, int[] vetBase, int[] vetCont)
        {
            int entro = 0;
            int[] vetTabela = new int[maior];

            for (int i = menor, j = 0; i <= maior; i++, j++)
            {
                vetTabela[j] = 0;
            }

            for(int i = 0; i < vetBase.Length;i++)
            {
                vetTabela[vetBase[i]-1] = vetCont[i];
            }

            //Se for para utilizar a solução abaixo, colocar no for de cima (vetTabela[i]=i)

           /* for(int i = 0;i<= maior-1; i++)
            {
                for(int j = 0; j < vetBase.Length ; j++)
                {
                    if (vetTabela[i] == vetBase[j])
                    {
                        vetTabela[i] = vetCont[j];
                        entro++;
                        break;
                    }
                }
                if(entro == 0)
                {
                    vetTabela[i] = 0;
                }
                entro = 0;
            }*/


            return vetTabela;

        }
        static int[] OrdenaVetor(int[] vetBase, int[] vetTabela)
        {
            int aux = 0;
            Console.WriteLine();
            Console.WriteLine("Vetor Ordenado: ");

            int[] vetOrdenado = new int[vetBase.Length];

            for(int i=0; i < vetTabela.Length;i++)
            {

                for(int j = 0; j < vetTabela[i]; j++)    // Preencho o vetor cm base nos valores de repetição da minha tabela
                {
                    vetOrdenado[aux] = i+1;
                    aux++;
                    
                }
            }
            return vetOrdenado;


        }



            static void preencheVetor(int[] vet)
            {
                Random randNum = new Random();
                for (int i = 0; i < vet.Length; i++)
                {
                    vet[i] = randNum.Next(1,10);
                }
            }
            static void imprimeVetor(int[] vet)
            {
                for (int i = 0; i < vet.Length; i++)
                {
                    Console.Write("\t" + vet[i]);
                }
                Console.WriteLine();
            }


        
    }
}
