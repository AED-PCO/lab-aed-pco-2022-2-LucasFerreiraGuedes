﻿using System;

namespace Fila_Encadeada
{
    class program
    {
        static void Main(string[] args)
        {

          /*  Aluno aluno1 = new Aluno("Lucas");
            Aluno aluno2 = new Aluno("Maria");
            Aluno aluno3 = new Aluno("Raquel");

            Elemento elemento1 = new Elemento(aluno1);
            Elemento elemento2 = new Elemento(aluno2);
            Elemento elemento3 = new Elemento(aluno3);

            */


            Fila Fila = new Fila();

            string res = "s";

            while(res == "s")
            {
                Console.WriteLine("Digite nome do Aluno:  ");
                string nome = Console.ReadLine();
                Fila.Inserir(nome);

                Console.WriteLine("Deseja inserir mais alunos? Digite s ou n");
                res = Console.ReadLine();
                

            }

            

          /*  Fila.Inserir(elemento1);
            Fila.Inserir(elemento2);
            Fila.Inserir(elemento3);
          */




           // Fila.Remover();
            Fila.ImprimeFila();

          //  Fila.ImprimeFila();
            //Fila.Inserir(elemento1);
            //  Console.WriteLine(elemento1.proximo.aluno.Nome);

            // Fila.ImprimeFila();





        }
    }
}