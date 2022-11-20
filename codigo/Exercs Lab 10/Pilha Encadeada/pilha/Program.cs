using System;

namespace Pilha_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Aluno aluno1 = new Aluno("Lucas", 89);
            Aluno aluno2 = new Aluno("Thaisinha", 91);

            Elemento elemento1 = new Elemento(aluno1);
            Elemento elemento2 = new Elemento(aluno2);
           /* elemento1.proximo = elemento2;

            Console.WriteLine(elemento1.proximo.aluno.Nome);  */ 

            Pilha pilha1 = new Pilha();
            
            pilha1.Insere(elemento1);
            pilha1.Insere(elemento2);

            //global::System.Console.WriteLine(pilha1.primeiro.aluno.Nome);
            //Console.WriteLine(pilha1.ultimo.aluno.Nome);
             
             pilha1.Escreve();

        }
    }
}
