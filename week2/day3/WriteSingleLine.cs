using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @".\each-line.txt";

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                try
                {
                    writer.WriteLine("Jeffery_Jiang");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }

        
    }
}