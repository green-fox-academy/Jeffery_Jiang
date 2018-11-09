
using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            int[] p1;
            p1 = new int[] {1, 2, 3};
            int[] p2 = new int[] {4, 5,4,2,3};

            if (p2.Length > p1.Length)

            {
                foreach (var number in p2)
                {
                    Console.WriteLine(number);
                }
                //Console.WriteLine(p2);
            }

            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
            Console.ReadLine();
        }
    }
}