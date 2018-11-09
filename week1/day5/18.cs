using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            int[] aj = {3, 4, 5, 6, 7};

            int i = 0;
            int j = aj.Length-1;
            int swap;
            while (i != j)
            {
                swap = aj[j];
                aj[j] = aj[i];
                aj[i] = swap;
                i++;
                j--;
            }

            foreach (int i1 in aj)
            {
                Console.WriteLine(i1);
            }
            // - Print the elements of the reversed `aj`
            Console.ReadLine();
        }
    }
}