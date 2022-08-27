using System;

namespace Fatorial_Recursivo
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Fat(4));


        }

        static int Fat(int number)
        {
            if (number == 1)
            {
                return number;
            }
            return number *= Fat(number - 1);
        }
    }
}