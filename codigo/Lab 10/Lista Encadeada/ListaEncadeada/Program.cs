using System;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {


            Aluno aluno1 = new Aluno("Lucas", 30);
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
            /* lista.InsercaoLinear(elemento2);
             lista.InsercaoLinear(elemento3);
             lista.InsercaoLinear(elemento4);
             lista.InsercaoLinear(elemento5); */




            //lista.InsercaoPos(elemento5, 1);

            /* Console.WriteLine("Primeiro aluno: "+lista.Primeiro.aluno.Nome);
             Console.WriteLine("Último  aluno: " + lista.Ultimo.aluno.Nome);
             Console.WriteLine(); */

            //Console.WriteLine(lista.Contador);



            //lista.ImprimeLista();

            // lista.RemoveElemento(elemento2);



            //  lista.ImprimeLista();

            lista.RemoveElemento(elemento1);

            

            lista.ImprimeLista();


        }
    }
}