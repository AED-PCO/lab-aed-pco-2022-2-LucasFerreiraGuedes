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
            Console.WriteLine("Deseja adicionar ou remover itens na lista? ");
            string resposta = Console.ReadLine().ToLower();
 
            if (resposta == "adicionar")
            {
                Console.WriteLine("Digite a posição em que deseja inserir o item na lista: ");
                pos = int.Parse(Console.ReadLine());
                AdicionarItens(ref lista, ref pos);
 
            }
            else if (resposta == "remover")
                Console.WriteLine("Digite qual a posição que deseja retirar o item: ");
            pos = int.Parse(Console.ReadLine());
                RemoverItens(ref lista, ref pos);
 
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
                    System.Console.WriteLine("Digite a posição emq ue se deseja retirar um número: ");
                    pos = int.Parse(Console.ReadLine());
                    RemoverItens(ref lista, ref pos);
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
 
                Console.WriteLine("Digite a posição em que deseja inserir o item na lista: ");
                pos = int.Parse(Console.ReadLine());
                AdicionarItens(ref lista, ref pos);
 
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
 
    }
}
