using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            string[] animals = {"koal", "pand", "zebr"};
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";

            }

            // - Add all elements an `"a"` at the end
            Console.ReadLine();
        }
    }
}