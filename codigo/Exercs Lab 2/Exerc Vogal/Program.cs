using System;

namespace Exerc_Vogal
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(RetornaSemVogal("Lucas"));

           
        }

        static string RetornaSemVogal(string frase)
        {
            frase = frase.ToLower();
 
            if(frase == "")
            {
                return "";
            }
            if (frase[frase.Length - 1]== 'a'|| frase[frase.Length-1] == 'e' || frase[frase.Length-1] == 'i' || frase[frase.Length -1] == 'o' || frase[frase.Length-1] == 'u')  
            { 
                
                return RetornaSemVogal(frase.Substring(0, frase.Length - 1));
            }
            return  RetornaSemVogal(frase.Substring(0,frase.Length-1)) + frase[frase.Length - 1] ;
        }


    }
}