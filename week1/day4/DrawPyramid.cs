using System;

namespace someexersice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("levels?: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");


                }
                Console.WriteLine();

            }

            Console.ReadKey();


        }
    }
}
