using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numList`
            int[] numList = {3, 4, 5, 6, 7};
            int[] douList = doubleArray(numList);
            foreach (var VARIABLE in douList)
            {
                Console.Write("{0} ",VARIABLE);
            }
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            Console.ReadLine();
        }

        static int[] doubleArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;

            }

            return array;
        }

        
    }
}