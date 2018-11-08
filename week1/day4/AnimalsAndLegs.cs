using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("How many Chiken");

            int chik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many pigs");
            int pig = Convert.ToInt32((Console.ReadLine()));

            int legs = 4 * pig + 2 * chik;
            Console.WriteLine("all legs are "+legs);

        }
    }
}