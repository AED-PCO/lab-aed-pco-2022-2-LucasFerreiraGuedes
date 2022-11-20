using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    internal class Aluno
    {

        public String Nome { get; set; }

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
