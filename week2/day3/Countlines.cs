using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @".\each-line.txt";

            Console.WriteLine(findLine(filepath));
            Console.ReadLine();


        }

        static int findLine(string filename)
        {
            string[] contents;
            int lines;
            try
            {
                contents = File.ReadAllLines(filename);
                if (contents == null)
                {
                    throw new Exception("no content");
                }

                lines = contents.Length;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                lines=0;
            }

            return lines;
        }
    }
}