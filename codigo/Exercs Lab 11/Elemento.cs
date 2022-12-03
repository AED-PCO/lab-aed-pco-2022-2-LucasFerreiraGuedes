using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Encadeada
{
    internal class Elemento
    {

        public Aluno aluno { get; set; }
        public Elemento proximo = null;
        public Elemento anterior { get; set; }


        public Elemento(Aluno aluno)
        {
            this.aluno = aluno;
        }
        public Elemento()
        {

        }
    }
}
