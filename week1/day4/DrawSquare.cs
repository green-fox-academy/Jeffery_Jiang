using System;

using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("level?");

            int level = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=level; i++)
            {
                Console.Write('%');

            }

            Console.WriteLine();
            for (int i = 2; i <= level - 1; i++)
            {
                Console.Write('%');
                for (int j = 2; j <= level - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write('%');
                Console.WriteLine();
            }
            for (int i = 1; i <= level; i++)
            {
                Console.Write('%');

            }

            Console.ReadKey();
        }
    }
}