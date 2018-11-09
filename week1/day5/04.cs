using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `Sum` that sums all the numbers
            //Console.ReadLine();

           Console.WriteLine(Sum());
            Console.ReadKey();
            //   until the given parameter and returns with an integer
        }

        static int Sum(params int[] intArrays)
        {
            int sum=0;
            foreach (var number in intArrays)
            {
                sum += number;
            }
            return  sum;

        }
    }