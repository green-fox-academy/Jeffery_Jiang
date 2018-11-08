using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            string name = "Jeffery";
            int age = 23;
            decimal height = 185/100;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);

            //  Example output:
            //  John Doe
            //  31
            //  1.87
        }
    }
}