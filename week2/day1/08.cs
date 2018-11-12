using System;
using System.Collections.Generic;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "bo", "anacond", "koal", "pand", "zebr" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

           // Console.WriteLine(AppendA(far));
            // Expected output: "boa", "anaconda", "koala", "panda", "zebra"
        }

        static void AppendA(List<string> far)
        {
            for (int i = 0; i < far.Count; i++)
            {
                far[i] = far[i] + "a";
            }
        }
    }
    
    
}