using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha_Encadeada
{
    class Pilha
    {

        public Elemento primeiro = null;
        


        public void Insere(Elemento elemento)
        {
             
            if (primeiro == null){
                
                primeiro = elemento;
            }
            else{

                 elemento.proximo = primeiro;
                 primeiro = elemento;  

            }

        }
       public void Escreve(){
          
         while(primeiro != null){
            System.Console.WriteLine(primeiro.aluno.Nome);
            primeiro = primeiro.proximo;
         }

       }

       public void Remover(){
         if(primeiro == null){
            System.Console.WriteLine("Não há itens para serem removidos !");
       }
       else{
           
           
           System.Console.WriteLine($"Item removido {primeiro}");
           
           Elemento aux = primeiro.proximo;
           primeiro.proximo = null;
           primeiro = aux;
          
       }

       }
    }
}
