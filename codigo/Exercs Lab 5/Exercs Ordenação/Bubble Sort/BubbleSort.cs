using System;

namespace Exerc_1
{
    class Program
    {
        static void Main(string[] args)
        {
         for (int i = 1000; i < 9999; i++)
         {
            int numeroLido = i;

            string primeiraMetade = numeroLido.ToString();
          primeiraMetade = primeiraMetade.Substring(0,2);
          

          string segundaMetade = numeroLido.ToString();
          segundaMetade = segundaMetade.Substring(2);
          

        
          var soma = int.Parse(segundaMetade) + int.Parse(primeiraMetade);

          if(Math.Pow(soma,2)== numeroLido)
          {
            Console.WriteLine($"O  {numeroLido} é Quadrado esta certo");
            
          }
          
         }   
           
        }
    }
}
