using System;
 
namespace Modelo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos itens terá em sua lista: ");
            int quantidadeItens = int.Parse(Console.ReadLine());
          
            int[] fila = new int[quantidadeItens];
            int referencia = 0; 
            PerguntaUsuario(ref fila, ref referencia);
            imprimeVetor(fila);
 
 
        }
        static void PerguntaUsuario(ref int[] fila,ref int referencia)
        {
            Console.WriteLine("Deseja adicionar ou remover itens na fila? ");
            string resposta = Console.ReadLine().ToLower();
 
            if (resposta == "adicionar")
                AdicionarItens(ref fila, ref referencia);
            else if(resposta ==  "remover")
                RemoverItens(ref fila);
 
            
 
            Console.WriteLine("Deseja encerrar o programa ou voltar a tela anterior? ");
            string segundaResposta = Console.ReadLine().ToLower();
            if (segundaResposta == "encerrar")
            {
                return;
            }
               
            else if (segundaResposta == "voltar")
            {
                Console.Clear();
                PerguntaUsuario(ref fila, ref referencia);
            }
 
        }
 
        static void AdicionarItens(ref int[] fila, ref int referencia)
        {
            Console.Clear();
 
            string res = "s";
 
             for(int i = 0; i <= fila.Length; i++)
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
        
 
 
        static void RemoverItens(ref int[] fila)
        {
            string res = "s";
            for(int i=0; i <= fila.Length; i++)
            {
                if (i + 1 >= fila.Length)
                    break;
 
                fila[i] = fila[i+1];
 
            }
            Console.WriteLine("Deseja remover mais itens? s ou n");
            res = Console.ReadLine();
 
            if (res == "s")
                RemoverItens(ref fila);
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
 
 
