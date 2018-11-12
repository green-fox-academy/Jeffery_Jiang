using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            //Console.WriteLine(QuoteSwap(list));
            Swap(list,"do","cannot");

            foreach (var VARIABLE in list)
            {
                Console.Write(VARIABLE+" ");
            }

            Console.ReadKey();
            // Expected output: "What I cannot create I do not understand." 
        }

        static void Swap(List<string> list, string a, string b)
        {
            if (list.Contains(a) && list.Contains(b))
            {
                string c;
                int x = list.IndexOf(a);
                int y = list.IndexOf(b);
                c = list[x];
                list[x] = list[y];
                list[y] = c;
            }
            else
            {
                return;
                
            }


        }