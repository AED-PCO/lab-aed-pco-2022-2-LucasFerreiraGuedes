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
            Elemento aux = Primeiro;
            if (pos <= Contador)
            {
                for (int i = 1; i < pos; i++)  // Aqui eu sobrescrevo um elemento de acordo com o pos passado, parando uma posição a frente e referenciando utilizando o .proximo
                {
                    aux = aux.proximo;
                                              // Se eu quiser fazer o shift, eu coloco aux.proximo e i = 0
                }
                elemento.proximo = aux.proximo.proximo;
                aux.proximo = elemento;
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
                        return;
                    }
                    else
                    {
                        aux = aux.proximo;
                    }
                }
                Console.WriteLine("O elemento não existe nesta Lista");
            }
 
 
        }
        public void RemoveUltimo()
        {
 
            var aux = Primeiro;
 
 
            if (aux == null)
            {
                Console.WriteLine("Não há itens para serem retirados");
            }
            else if(Primeiro == Ultimo)            {
                Primeiro = Ultimo = null;
            }
            else
            {
               
                while (aux.proximo != Ultimo) // tem mais de um elemento na lista
                {
                    aux = aux.proximo;
                }
                aux.proximo = null;
                Ultimo = aux;    
            }
        }
 
        public void ImprimeLista()
        {
           
 
            if (Primeiro == null)
            {
                Console.WriteLine("Não existem itens nesta lista");
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
 
            Console.WriteLine();
 
        }
    }
}
