using System;
using System.Text;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReverseString(reversed));
            Console.ReadKey();
        }

        static StringBuilder ReverseString(string oringal)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = oringal.Length-1; i >= 0; i--)
            {
                reversed.Append(oringal[i]);

            }

            return reversed;
        }
    }
}
