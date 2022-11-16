using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha_Encadeada
{
    class Elemento
    {

        public Aluno aluno { get; set; }

        public Elemento proximo = null;


        public Elemento()
        {
            
        }

        public Elemento(Aluno aluno)
        {
            this.aluno = aluno;
        }
    }
}
