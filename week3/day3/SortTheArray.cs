using System;
using System.Linq;

namespace SortTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {4, 2, 1, 2, 6, 5};

            Sort(a);
            Console.WriteLine("Hello World!");
        }

        public static void Sort<T>(T[] array) where T : IComparable
        {
            try
            {
                // very important here. 
                var result = array.OrderByDescending(a=>a);

                foreach (var variable in result)
                {
                    Console.WriteLine(variable.ToString());
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("can not be sorted");
            }
        }
    }

}