using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    internal class Lista
    {
        public Elemento Primeiro = null;

        public Elemento Ultimo = null;

        public int Contador = 0;

        public Lista()
        {

        }

        public void InsercaoLinear(Elemento elemento)
        {
            if (Primeiro == null)
            {
                Primeiro = elemento;
                Ultimo = elemento;
                Contador++;
            }
            else
            {
                Ultimo.proximo = elemento;
                Ultimo = elemento;
                Contador++;
            }

        }

        public void InsercaoPos(Elemento elemento, int pos)
        {
            var aux = Primeiro;

            if (pos <= Contador)
            {
                for (int i = 0; i < pos; i++)  // Aqui eu sobrescrevo um elemento de acordo com o pos passado, parando uma posição a frente e referenciando utilizando o .proximo
                {
                    aux = aux.proximo;

                }
                aux = elemento;
            }
            else
            {

                InsercaoLinear(elemento);  //Quando meu pos é maior do que a pos presente na lista, eu o insiro no final dela.
            }

        }



        public void RemoveElemento(Elemento elemento)
        {
            Elemento aux = Primeiro;

            if (aux == elemento)
            {
                aux = aux.proximo;
            }
            else
            {


                while (aux != null)
                {

                    if (aux.proximo == elemento)
                    {
                        aux.proximo = elemento.proximo;
                        break;
                    }
                    else
                    {
                        aux = aux.proximo;
                    }
                }
            }


        }
        public void RemoveUltimo()
        {

            var aux = Primeiro;
           

            if (aux == null)
            {
                throw new Exception("Não há itens para serem retirados");
            }

            else
            {

                while (aux.proximo != null)
                {
                    aux = aux.proximo;
                }
                aux.proximo = null;

            }
        }

            public void ImprimeLista()
            {
                Console.WriteLine();
             
            if(Primeiro == null)
            {
                throw new Exception("Não existem itens nesta lista");
            }

            else
            {
                var aux = Primeiro;


                Console.Write(aux.aluno.Nome + "\t");

                while (aux.proximo != null)
                {
                    Console.Write(aux.proximo.aluno.Nome + "\t");

                    aux = aux.proximo;
                }
            }
                
            }
        
    }
}
