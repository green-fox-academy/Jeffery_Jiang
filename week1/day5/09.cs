using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `s`
            int[] s = {1, 2, 3, 8, 5, 6};
            int count = 0;
            foreach (var number in s)

            {
                
                if (number == 8)
                {
                     s[count]= 4;
                }

                count++;
            }
            Console.WriteLine(s[3]);
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
            Console.ReadLine();
        }
    }
}