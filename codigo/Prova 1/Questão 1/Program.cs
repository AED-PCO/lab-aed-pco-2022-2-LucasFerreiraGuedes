using System;
 
namespace Questao1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto para ser verificado se existe no Arquivo");
            string texto = Console.ReadLine();
            ConfereArquivo(texto);
        }
        static void ConfereArquivo(string text)
        {
            int cont = 0, diferente = 0, entro=0;
            StreamReader SR = new StreamReader("C:\\Users\\1405925\\Desktop\\Prova\\Questao1\\teste.txt");
            
 
            string[] ARQ = SR.ReadToEnd().Split(' ');
            //Console.WriteLine(ARQ[ARQ.Length-1]);
            string[] TXT = text.Split(' ');
            for (int i = 0; i <= ARQ.Length-1; i++)
            {
                
                for (int j = 0; j < TXT.Length; j++)
                {
                    if (ARQ[i] == TXT[j])
                    {
                        cont++;
                        entro++;
                    }
                    
                }
                if (entro == 0)
                {
                    diferente++;
                }
                entro = 0;
            }
            SR.Close();
            Console.WriteLine($"O número de termos iguais são: {cont}" );
            Console.WriteLine($"O número de termos diferentes são: {diferente}");
 
        }
       
 
 
 
        }
    }
