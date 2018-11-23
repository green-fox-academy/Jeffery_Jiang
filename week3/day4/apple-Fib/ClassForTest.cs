using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApp1
{
    public class ClassForTest
    {

        public string GetApple()
        {
            return "apple";
        }

        public object Sum(List<int> numList)
        {
            if (numList == null)
            {
                return null;
            }
            var sum = 0;
            foreach (var VARIABLE in numList)
            {
                sum += VARIABLE;
            }

            return sum;
        }

        public bool IsAnagrame(string source1, string source2)
        {

            string str1 = source1.Trim().Replace(" ","");
            string str2 = source2.Trim().Replace(" ","");
            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            string outputStr1 = new string(charArray1);
            string outputStr2 = new string(charArray2);
            //  Console.WriteLine("str1: "+outputStr1);
            //  Console.WriteLine("str2: "+outputStr2);

            return outputStr2.Equals(outputStr1);

        }

        public Dictionary<char, int> CountLetters(string source)
        {
            Dictionary<char,int> outputDictionary=new Dictionary<char, int>();
            char[] charArray = source.Trim().Replace(" ","").ToCharArray();
            foreach (var letter in charArray)
            {
                if ((letter>=97 && letter<=122) || (letter>=65 && letter<=90))
                {
                    if (outputDictionary.ContainsKey(letter))
                    {
                        outputDictionary[letter]++;
                    }
                    else
                    {
                        outputDictionary.Add(letter, 1);
                    }
                }
            }

            return outputDictionary;
        }

        public int Fibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
