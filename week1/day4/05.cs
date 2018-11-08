using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 13;

            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22
            Console.WriteLine("sum: {0}",a+b);

            // Print the result of 13 substracted from 22
            Console.WriteLine("subs: {0}", a-b);
            // Print the result of 22 multiplied by 13
            Console.WriteLine("multi: {0}", a*b);
            // Print the result of 22 divided by 13 (as a decimal fraction)
            Console.WriteLine("div: {0}", (double) a/b);

            // Print the integer part of 22 divided by 13
            Console.WriteLine("div integer: {0}", a/b);
            // Print the reminder of 22 divided by 13
            Console.WriteLine("div reminder： {0} ",((double) a/b -(int) a/b) );

            Console.ReadKey();
        }
    }
}