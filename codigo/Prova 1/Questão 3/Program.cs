using System;

namespace Modelo
{
    class program
    {
        static void Main(string[] args)
        {
            EscrevaArquivo();
        }
    
      static void EscrevaArquivo()
        {
            StreamReader SR = new StreamReader("C:\\Users\\alefa\\OneDrive\\Área de Trabalho\\AED Exercs\\QuestoesProva1\\Questao_3\\entrada.txt");

          
             string PrimeiraL = SR.ReadToEnd();
            char[] arr = PrimeiraL.ToCharArray();
            //char[] arr  = SR.ReadToEnd().ToCharArray(); também há esta forma mais direta de fazer !!
            SR.Close();

            StreamWriter SW = new StreamWriter("C:\\Users\\alefa\\OneDrive\\Área de Trabalho\\AED Exercs\\QuestoesProva1\\Questao_3\\saida.txt");
            for (int i = arr.Length-1; i >= 0; i--)
            { 
                if (arr[i] == ' ')
                {
                    SW.Write(" ");
                }
                else
                 SW.Write(arr[i]);
            }
            SW.Close();



        }
    
    
    
    
    }
}

