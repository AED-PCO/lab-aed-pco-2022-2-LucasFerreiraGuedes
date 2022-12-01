using System;

namespace Lista_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            string res = "s";

            while (res == "s")
            {
                Console.WriteLine("Digite nome do Aluno:  ");
                string nome = Console.ReadLine();
                lista.InsercaoLinear(nome);

                Console.WriteLine("Deseja inserir mais alunos? Digite s ou n");
                res = Console.ReadLine();


            }


            Console.WriteLine("Digite um nome que se deseja retirar da lista: ");
            string name = Console.ReadLine();
            lista.RemoveElemento(name);

            /*  Aluno aluno1 = new Aluno("Lucas", 30);
              Aluno aluno2 = new Aluno("Thais", 30);
              Aluno aluno3 = new Aluno("Henrique", 19);
              Aluno aluno4 = new Aluno("Igor", 23);
              Aluno aluno5 = new Aluno("Hugo", 17);


              Elemento elemento1 = new Elemento(aluno1);
              Elemento elemento2 = new Elemento(aluno2);
              Elemento elemento3 = new Elemento(aluno3);
              Elemento elemento4 = new Elemento(aluno4);
              Elemento elemento5 = new Elemento(aluno5);

              Lista lista = new Lista();

              lista.InsercaoLinear(elemento1);
              lista.InsercaoLinear(elemento2);
              lista.InsercaoLinear(elemento3);
              lista.InsercaoLinear(elemento4);
              lista.InsercaoLinear(elemento5);

              */




            // lista.InsercaoPos(elemento5, 1);

            /* Console.WriteLine("Primeiro aluno: "+lista.Primeiro.aluno.Nome);
             Console.WriteLine("Último  aluno: " + lista.Ultimo.aluno.Nome);
             Console.WriteLine(); */

            //Console.WriteLine(lista.Contador);



            /* lista.ImprimeLista();

             lista.RemoveElemento(elemento2);



              lista.ImprimeLista(

             lista.ImprimeLista();
             lista.InsercaoPos(elemento2, 1);

             lista.ImprimeLista();

             lista.InsercaoLinear(elemento3);
            */
            lista.ImprimeLista();


        }
    }
}