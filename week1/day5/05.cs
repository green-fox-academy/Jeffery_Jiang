using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            int a = 4;
            Console.WriteLine(Factorio(a));
            Console.ReadLine();
        }

        static int Factorio(int a)
        {
            int sum=0;
            if (a == 0)
            {
                return 1;
            }
            else
            {
                sum = a * Factorio(a - 1);
            }

            return sum;

        }
    }
}