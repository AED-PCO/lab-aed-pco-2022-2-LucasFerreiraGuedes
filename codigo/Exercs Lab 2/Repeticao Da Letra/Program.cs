using System;

namespace Exerc_Recursivo
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma palavra: ");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite uma letra para ver a ocorrencia dela na palavra escrita anteriormente: ");
            char letra = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine($"O número de repetições desta letra nesta palvra é: {OcorrenciaLetra(frase,letra)}");
            
        }

        static int OcorrenciaLetra(string frase, char letra)
        {
            if (frase == "")
            {
                return 0;

            }
            if (frase[frase.Length-1] == letra)
            {
                return 1 + OcorrenciaLetra(frase.Substring(0,frase.Length - 1), letra);

            }
            return OcorrenciaLetra(frase.Substring(0, frase.Length - 1), letra);
        }

    }

}

