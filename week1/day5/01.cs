using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            int baseNum = 123;

            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            Console.WriteLine(Doubling(baseNum));
                // - Print the result of `Doubling(baseNum)`
                Console.ReadLine();
        }
        static int Doubling(int baseNum)
        {
            return baseNum * 2;
        }
    }
}