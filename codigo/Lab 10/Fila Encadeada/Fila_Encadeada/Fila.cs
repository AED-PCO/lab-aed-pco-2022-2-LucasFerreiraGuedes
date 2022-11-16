using System;
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
        public void Inserir(Elemento elemento)
        {
            if(Primeiro == null) // quer dizer que não existe nenhum elemento em minha fila
            {
                Primeiro = elemento;
            }
            else
            {
                var ponteiro = Primeiro;
                while (ponteiro.proximo != null)
                {
                    ponteiro = ponteiro.proximo;

                }
                ponteiro.proximo = elemento; 
            }
        }

        public void Remover()
        {
            if (Primeiro == null)
            {
                throw new Exception("Não existem itens nesta fila para serem retirados");
            }
            else
            {
                Primeiro = Primeiro.proximo;
            }
            
        }


    
    
    
    }
}
