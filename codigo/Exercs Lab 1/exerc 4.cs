using System;

namespace Exerc_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Mat = new int[5, 3];

            LeMatriz(Mat);
            EscreveMatriz(Mat);
            SomaLinha(Mat);
            SomaColuna(Mat);
        }
        
        static void LeMatriz(int[,] M)
        {
            for(int i = 0; i < M.GetLength(0); i++)
            {
                for(var j = 0; j < M.GetLength(1); j++)
                {
                    Console.WriteLine("Digite um valor para ser alocado na Matriz");
                    M[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
        }
        static void SomaLinha(int[,] M)
        {
            int soma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (var j = 0; j < M.GetLength(1); j++)
                {
                    soma += M[i, j];
                }
                
                Console.WriteLine($"A soma da {i + 1}º linha é {soma}");
                soma=0;
            }
            Console.WriteLine();
        }
        static void SomaColuna(int[,] M)
        {
            int soma = 0;

            for (int i = 0; i < M.GetLength(1); i++)
            {
                for (var j = 0; j < M.GetLength(0); j++)
                {
                    soma += M[j, i];
                }
                Console.WriteLine($"A soma da {i + 1}º coluna é {soma}");
                soma=0;
            }
            Console.WriteLine();
        }
        static void EscreveMatriz(int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (var j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(M[i,j] + "\t");
                }
                Console.WriteLine();
               
            }
            Console.WriteLine();
        }
    }
}
