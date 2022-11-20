using System;

namespace Modelo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos itens terá em sua pilha: ");
            int quantidadeItens = int.Parse(Console.ReadLine());

            int[] pilha = new int[quantidadeItens];
            int referencia = 0;
            int itensRemovidos = 0;
            
            PerguntaUsuario(ref pilha, ref referencia, ref itensRemovidos);
            imprimeVetor(pilha);


        }
        static void PerguntaUsuario(ref int[] pilha, ref int referencia, ref int itensRemovidos)
        {
            Console.WriteLine("Deseja adicionar ou remover itens na Pilha? ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "adicionar")
            {
                if (referencia + 1 > pilha.Length)   // Aqui eu verifico se pilha ja foi totalmente preenchida
                {
                    if (itensRemovidos == 0)  
                    {
                        Console.WriteLine($"Esta pilha esta cheia, para adicionar mais itens, deve-se retirar o último item {pilha[pilha.Length-1]}");
                        Console.WriteLine("Deseja retirar este item? s ou n");
                        string res2 = Console.ReadLine();

                        if (res2 == "s")
                        {

                            RemoverItens(ref pilha, ref itensRemovidos);
                            AdicionarItens(ref pilha, ref referencia, ref itensRemovidos);

                        }
                    }
                    else // Aqui, ela foi totalmente preenchida, mas ocorreu remoções
                    {
                        AdicionarItens(ref pilha, ref referencia, ref itensRemovidos);
                    }
                    
                    
                }
                else
                {
                    AdicionarItens(ref pilha, ref referencia, ref itensRemovidos);
                }
            }
            else if (resposta == "remover")
                RemoverItens(ref pilha, ref itensRemovidos);

            Console.WriteLine("Deseja encerrar o programa ou voltar a tela anterior? ");
            string segundaResposta = Console.ReadLine().ToLower();
            if (segundaResposta == "encerrar")
            {
                return;
            }

            else if (segundaResposta == "voltar")
            {
                Console.Clear();
                PerguntaUsuario(ref pilha, ref referencia, ref itensRemovidos);
            }

        }

        static void AdicionarItens(ref int[] pilha, ref int referencia, ref int itensRemovidos)
        {
            Console.Clear();

            string res = "s";
            if (itensRemovidos >= 1)
            {
                referencia -= itensRemovidos;
                itensRemovidos = 0;

            }
                

            for (int i = referencia; i < pilha.Length; i++)
            {
          
                    Console.WriteLine("Digite o valor que deseja inserir na pilha: ");
                    pilha[i] = int.Parse(Console.ReadLine());
                    referencia++;
                
                Console.WriteLine("Deseja adicionar mais itens? s ou n");
                res = Console.ReadLine();

                if (res == "n")
                {
                    Console.WriteLine("Pilha Preenchida: ");
                    imprimeVetor(pilha);
                    return;
                }
                    
            }

            Console.WriteLine("Não é possivel mais adicionar itens nesta Pilha");
            Console.WriteLine("Pilha Preenchida: ");
            imprimeVetor(pilha);

        }



        static void RemoverItens(ref int[] pilha,ref int itensRemovidos)
        {
            string res = "s";
            for (int i = pilha.Length - 1; i >= 0; i--)
            {
                if (i - 1 == -1) // Checo para ver se não ja cheguei no último valor válido na pilha
                {
                    Console.WriteLine($"Item removido: {pilha[i]} ");
                    pilha[i] = pilha[i];
                    Console.WriteLine("Não há mais itens a serem retirados nesta Pilha");
                    itensRemovidos++;
                    return;
                }
                   
                if (res == "s")
                {
                    Console.WriteLine($"Item removido: {pilha[i]} ");
                    pilha[i] = pilha[i - 1];
                    itensRemovidos++;
                    
                }
                Console.WriteLine("Deseja remover mais itens? s ou n");
                res = Console.ReadLine();

                if (res == "n")
                {
                    return;
                }
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



