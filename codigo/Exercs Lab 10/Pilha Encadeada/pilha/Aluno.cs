using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha_Encadeada
{
    class Aluno
    {

        public string Nome { get; set; }

        public double Nota { get; set; }



        public Aluno()
        {

        }

        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }


    }
}
