using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
        //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            //  Example:
            Console.WriteLine(Substr("this is what I'm searching in", "searching"));
            //  should print: `17`
            Console.WriteLine(Substr("this is what I'm searching in", "not"));
            //  should print: `-1`

            Console.ReadKey();
        }

        static int Substr(string input, string q)
        {
            int len1 = input.Length;
            int len2 = q.Length;
            int index=0;
            int i, j;

            if (input.Contains(q))
            {
                for (i = 0; i <= len1-1; i++)
                {
                    if (input[i] == q[0])
                    {
                        for (j = 1; j <= len2-1 ; j++)
                        {
                            if (input[i + j] != q[j])
                            {
                                break;
                            }

                            if (j == len2-1)
                            {
                                index = i; //return i + j;
                            }
                        }
                    }
                    else
                    {
                        continue;
                        
                    }
                }
            }
            else
            {
                index = -1;
                //return -1;
            }

            return index;
        }
    }
}