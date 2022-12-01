﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_Encadeada
{
    internal class Fila
    {

        public Elemento Primeiro = null;

        public Fila()
        {

        }
        public void Inserir(string nome)
        {
            Elemento dado = new Elemento();
            dado.aluno = new Aluno();
            dado.aluno.Nome = nome;

            if (Primeiro == null) // quer dizer que não existe nenhum elemento em minha fila
            {

                Primeiro = dado;

            }

            else
            {

                Elemento ponteiro = Primeiro;
                while (ponteiro.proximo != null)
                {
                   // Console.WriteLine(dado.proximo);
                    ponteiro = ponteiro.proximo;

                }
                ponteiro.proximo = dado;
            }
            //Console.WriteLine(Primeiro.aluno.Nome);
        }

        public void Remover()
        {


            if (Primeiro == null)
            {
                Console.WriteLine("Não existem itens nesta fila para serem retirados");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Item removido: " + Primeiro.aluno.Nome);
                Elemento aux = Primeiro.proximo;
                Primeiro.proximo = null;
                Primeiro = aux;
            }

        }

        public void ImprimeFila()

        {
            Console.WriteLine();

            Elemento ponteiro = Primeiro;

            while (ponteiro != null)
            {
                Console.Write(ponteiro.aluno.Nome + "\t");
                ponteiro = ponteiro.proximo;
            }


        }





    }
}