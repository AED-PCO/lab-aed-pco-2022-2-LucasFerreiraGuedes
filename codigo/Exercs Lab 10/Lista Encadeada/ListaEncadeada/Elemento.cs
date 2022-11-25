﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    internal class Elemento
    {

        public Aluno aluno { get; set; }
        public Elemento proximo = null;


        public Elemento(Aluno aluno)
        {
            this.aluno = aluno;
        }
        public Elemento()
        {

        }
    }
}