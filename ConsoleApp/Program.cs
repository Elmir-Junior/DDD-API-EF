using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Collatz();
        }

        static void Collatz()
        {
            int num = 1000000;
            int contador = 0;
            while (num > 1)
            {
                contador++;
                if (num % 2 == 0)
                {
                    num = num / 2;
                    Console.WriteLine(num);
                }
                else
                {

                    num = (num * 3) + 1;
                }
                Console.WriteLine("Numero de voltas {0}. Atual numero da conjectura {1}", contador, num);
            }
        }

    }
}
