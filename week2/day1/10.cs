using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list,new int[]{4,8,12,16,23}));

            Console.ReadKey();
        }

        static bool CheckNums(List<int> list,int[] a)
        {
            foreach (var VARIABLE in a)
            {
                if (list.Contains(VARIABLE))
                {
                    continue;                    
                }
                
                return false;
                
                
            }

            return true;
        }
    }
}