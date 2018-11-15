using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @".\each-line.txt";

            WriteMultipleLines(filepath,"I love Coding",5);


        }

        static void WriteMultipleLines(string filepath, string content, int lines)
        {
            try
            {
                StreamWriter writer = new StreamWriter(filepath);

                for (int i = 0; i < lines; i++)
                {
                    writer.WriteLine(content);
                }

                writer.Close();
            }
            catch (Exception e)
            {
                return;
            }
            
        }

        
    }
}