using System;

namespace Fila_Encadeada
{
    class program
    {
        static void Main(string[] args)
        {

          Aluno aluno1 = new Aluno("Lucas", 30);
          Aluno aluno2 = new Aluno("Maria", 27);
          Aluno aluno3 = new Aluno("Raquel", 12);

           Elemento elemento1 = new Elemento(aluno1);
          Elemento elemento2 = new Elemento(aluno2);
          Elemento elemento3 = new Elemento(aluno3);

            Fila Fila = new Fila();

            Fila.Inserir(elemento1);
            Fila.Inserir(elemento2);
            Fila.Inserir(elemento3);

            
            Fila.Remover();
            Console.WriteLine(Fila.Primeiro.aluno.Nome);

           // Console.WriteLine(elemento1.proximo.aluno.Nome);
         





        }
    }
}

