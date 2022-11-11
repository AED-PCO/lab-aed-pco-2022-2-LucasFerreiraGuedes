using System;

namespace Modelo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos itens terá em sua lista: ");
            int quantidadeItens = int.Parse(Console.ReadLine());

            int[] lista = new int[quantidadeItens];


            PerguntaUsuario(ref lista);
            imprimeVetor(lista);


        }
        static void PerguntaUsuario(ref int[] lista)
        {
            int pos = 0;
            Console.WriteLine("Deseja adicionar, remover itens na lista ou copiar ela? ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "adicionar")
            {
                Console.WriteLine("Digite a posição em que deseja inserir o item na lista: ");
                pos = int.Parse(Console.ReadLine());
                AdicionarItens(ref lista, ref pos);

            }
            else if (resposta == "remover")
            {
                Console.WriteLine("Digite qual a posição que deseja retirar o item: ");
                pos = int.Parse(Console.ReadLine());
                RemoverItens(ref lista, ref pos);
            }
            else if (resposta == "copiar")
            {
                CopiaLista(ref lista);
            }

            Console.WriteLine("Deseja encerrar o programa ou voltar a tela anterior? ");
            string segundaResposta = Console.ReadLine().ToLower();
            if (segundaResposta == "encerrar")
            {
                return;
            }

            else if (segundaResposta == "voltar")
            {
                Console.Clear();
                PerguntaUsuario(ref lista);
            }

        }

        static void AdicionarItens(ref int[] lista, ref int pos)
        {
            Console.Clear();
            int entro = 0;

            string res = "s";

            if (pos >= lista.Length || pos < 0)
            {
                System.Console.WriteLine("Esta posição não existe nesta lista");

                for (int i = 0; i < lista.Length; i++)
                {

                    if (lista[i] == 0)
                    {
                        Console.Write(i + " ");
                        entro++;
                    }
                }
                if (entro == 0)
                {
                    System.Console.WriteLine("Não existem posições disponíveis de inserção, favor retirar um número antes de inserir!");
                    System.Console.WriteLine("Deseja retirar um número ou voltar a tela inicial? ");
                    string ques = Console.ReadLine();
                    if (ques == "retirar")
                    {
                        Console.WriteLine("Digite a posição em que se deseja retirar um número: ");
                        pos = int.Parse(Console.ReadLine());
                        RemoverItens(ref lista, ref pos);
                    }
                    else if (ques == "voltar")
                    {
                        Console.Clear();
                        PerguntaUsuario(ref lista);
                    }
                }
                else
                {
                    Console.WriteLine();
                    System.Console.WriteLine("Acima estão as posições disponíveis de inserção");

                }
                    System.Console.WriteLine("Digite uma posição que seja válida: ");
                    pos = int.Parse(Console.ReadLine());
                    AdicionarItens(ref lista, ref pos);
                    entro = 0;
                
            }

                if (lista[pos] != 0)
                {
                    System.Console.WriteLine("Já existe um número ocupando está posição, deseja remove-lo ou adicionar ele em outra posição?");
                    string res2 = Console.ReadLine();

                    if (res2 == "adicionar")
                    {
                        Console.WriteLine("Digite a posição em que deseja inserir o item na lista: ");
                        pos = int.Parse(Console.ReadLine());
                        AdicionarItens(ref lista, ref pos);
                    }
                    else if (res2 == "remover")
                    {
                        RemoverItens(ref lista, ref pos);
                    }


                }
                while (res == "s")
                {
                    Console.WriteLine("Digite o valor que deseja inserir na lista: ");
                    lista[pos] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Deseja adicionar mais itens? s ou n");
                    res = Console.ReadLine();

                    if (res == "n")
                    {
                        Console.WriteLine("lista Preenchida: ");
                        imprimeVetor(lista);
                        PerguntaUsuario(ref lista);
                    }

                    Console.Clear();

                    for (int i = 0; i < lista.Length; i++)
                    {

                        if (lista[i] == 0)
                        {
                            Console.Write(i + " ");
                            entro++;
                        }
                    }
                    if (entro > 0)
                    {
                    Console.WriteLine();
                    System.Console.WriteLine("Acima estão as posições disponíveis de inserção");
                    Console.WriteLine("Digite a posição em que deseja inserir o item na lista: ");
                    pos = int.Parse(Console.ReadLine());
                    AdicionarItens(ref lista, ref pos);
                    entro = 0;
                    }
                else
                {
                    System.Console.WriteLine("Não existem posições disponíveis de inserção, favor retirar um número antes de inserir!");
                    System.Console.WriteLine("Deseja retirar um número ou voltar a tela inicial? ");
                    string ques = Console.ReadLine();
                    if (ques == "retirar")
                    {
                        Console.WriteLine("Digite a posição em que se deseja retirar um número: ");
                        pos = int.Parse(Console.ReadLine());
                        RemoverItens(ref lista, ref pos);
                    }
                    else if (ques == "voltar")
                    {
                        Console.Clear();
                        PerguntaUsuario(ref lista);
                    }
                }
                  

                }
                /* Console.WriteLine("Não é possivel mais adicionar itens nesta lista");
                 Console.WriteLine("lista Preenchida: ");
                 imprimeVetor(lista); */

            

        }

            static void RemoverItens(ref int[] lista, ref int pos)
            {
                string res = "s";

                if (pos >= lista.Length || pos < 0)
                {
                    System.Console.WriteLine("Esta posição não existe nesta lista, as posições disponíveis de para remoção são: ");

                    for (int i = 0; i < lista.Length; i++)
                    {

                        if (lista[i] != 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    System.Console.WriteLine("Digite uma posição que seja válida para remoção: ");
                    pos = int.Parse(Console.ReadLine());
                    RemoverItens(ref lista, ref pos);
                }

                if (lista[pos] == 0)
                {
                    System.Console.WriteLine("Não há itens adicionados nesta posição para serem retirados, favor digitar outra posição para remoção.As posições disponíveis de para remoção são:");

                    for (int i = 0; i < lista.Length; i++)
                    {

                        if (lista[i] != 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.WriteLine();
                    System.Console.WriteLine("Digite uma posição que seja válida para remoção: ");
                    System.Console.WriteLine("Deseja digitar outra posição para remover, ou voltar a tela incial? ");
                    string res2 = Console.ReadLine();

                    if (res2 == "remover")
                    {
                        System.Console.WriteLine("Digite a posição em que se deseja retirar um número: ");
                        pos = int.Parse(Console.ReadLine());
                        RemoverItens(ref lista, ref pos);
                    }
                    else if (res2 == "voltar")
                    {
                        Console.Clear();
                        PerguntaUsuario(ref lista);
                    }


                }


                while (res == "s")
                {
                    Console.WriteLine($"Item removido: {lista[pos]} ");
                    lista[pos] = 0;
                    System.Console.WriteLine("Deseja retirar mais itens nesta lista ? ");
                    res = Console.ReadLine();

                    if (res == "n")
                    {
                        return;
                    }

                    System.Console.WriteLine("Digite a posição da lista em que se deseja retirar um número: ");
                    pos = int.Parse(Console.ReadLine());
                    RemoverItens(ref lista, ref pos);



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

            static void CopiaLista(ref int[] lista)
            {
            Console.Clear();

                int[] ListaCopiada = new int[lista.Length * 2];
                int[] auxFila = new int[lista.Length];
                int[] auxPilha = new int[lista.Length];

                PreencheVetor(lista, ref auxFila);
                PreencheVetor(lista, ref auxPilha);
                PreencheVetor(lista, ref ListaCopiada);
                PreenchePilha(lista, ref ListaCopiada);

                Console.WriteLine("Lista Original: ");
                imprimeVetor(lista);

                Console.WriteLine("Lista Copiada: ");
                imprimeVetor(ListaCopiada);

                PerguntaUsuario(ref lista);

                // criar funções de saída tanto para a fila, quanto para a pilha

                // tratar como uma fila um vetor e outro como pilha




            }

            static void PreencheVetor(int[] lista, ref int[] vetaux)
            {
                for (int i = 0; i < lista.Length; i++)
                {

                    vetaux[i] = lista[i];
                }
            }
            static void PreenchePilha(int[] lista, ref int[] vetaux)
            {
                
                for (int i = lista.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    
                    vetaux[vetaux.Length / 2 + j] = lista[i];
                    
                }


            }
        }
    }

