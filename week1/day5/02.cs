using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            string al = "Greenfox";

            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`

            Console.WriteLine(Greet(al));
            // - Greet `al`
            Console.ReadKey();

        }

        static string Greet(string al)
        {
            return "Greeting dear, " + al;
        }
    }
}