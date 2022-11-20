using System;

namespace Modelo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos itens terá em sua fila: ");
            int quantidadeItens = int.Parse(Console.ReadLine());

            int[] fila = new int[quantidadeItens];
            int referencia = 0;
            int itensRemovidos = 0;
            PerguntaUsuario(ref fila, ref referencia, ref itensRemovidos);
            imprimeVetor(fila);


        }
        static void PerguntaUsuario(ref int[] fila, ref int referencia, ref int itensRemovidos)
        {
            Console.WriteLine("Deseja adicionar ou remover itens na fila? ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "adicionar")
                AdicionarItens(ref fila, ref referencia);
            else if (resposta == "remover")
                RemoverItens(ref fila,ref itensRemovidos);



            Console.WriteLine("Deseja encerrar o programa ou voltar a tela anterior? ");
            string segundaResposta = Console.ReadLine().ToLower();
            if (segundaResposta == "encerrar")
            {
                return;
            }

            else if (segundaResposta == "voltar")
            {
                Console.Clear();
                PerguntaUsuario(ref fila, ref referencia, ref itensRemovidos);
            }

        }

        static void AdicionarItens(ref int[] fila, ref int referencia)
        {
            Console.Clear();

            string res = "s";

            for (int i = 0; i <= fila.Length; i++)
            {
                if (referencia + 1 > fila.Length)
                {
                    Console.WriteLine("Não é possivel mais adicionar itens nesta fila");
                    Console.WriteLine("Fila preenchida: ");
                    imprimeVetor(fila);
                    break;
                }

                if (res == "s")
                {
                    fila[i] = int.Parse(Console.ReadLine());
                    referencia++;
                }
                Console.WriteLine("Deseja adicionar mais itens? s ou n");
                res = Console.ReadLine();
                if (res == "n")
                    break;

            }



        }



        static void RemoverItens(ref int[] fila, ref int itensRemovidos)
        {
            string res = "s";
           

            if (itensRemovidos == fila.Length)
            {
                Console.WriteLine("Todos os números presentes na fila foram retirados, para retirar mais itens, adicione os primeiro.");
                return;
            }

            Console.WriteLine($"Item Removido: {fila[0]}");

            for (int i = 0; i < fila.Length && res == "s"; i++)
            {
                if (i + 1 >= fila.Length)
                    break;

                
                fila[i] = fila[i + 1];

            }
            itensRemovidos++;
            Console.WriteLine("Deseja remover mais itens? s ou n");
            res = Console.ReadLine();
            
                

            if (res == "s")
                RemoverItens(ref fila, ref itensRemovidos);
            else
            {
                return;
            }



        }

        static void imprimeVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("\t" + vet[i]);
            }
            System.Console.WriteLine();
        }

    }
}



