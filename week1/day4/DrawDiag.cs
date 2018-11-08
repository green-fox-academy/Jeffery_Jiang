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
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("level?");

            int level = Convert.ToInt32(Console.ReadLine());
            int diag = 0;
            for (int i = 1; i <=level; i++)
            {
                Console.Write('%');

            }

            Console.WriteLine();
            for (int i = 2; i <= level - 1; i++)
            {
                diag = i;
                Console.Write('%');
                for (int j = 2; j <= level - 1; j++)

                {
                    if (j == diag)
                    {
                        Console.Write('%');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
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