using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @".\each-line.txt";
            string anotherfilepath = @".\another-file.txt";
            Console.WriteLine(CopyFile(filepath,anotherfilepath));

            Console.ReadLine();
            //WriteMultipleLines(filepath,"I love Coding",5);


        }

        static bool CopyFile(string filename1, string filename2)
        {
            string line = "";
            try
            {
                StreamWriter writer = new StreamWriter(filename2);
                StreamReader reader = new StreamReader(filename1);
                while (line != null)
                {
                    line = reader.ReadLine();
                    writer.WriteLine(line);
                }
                reader.Dispose();
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("fail to copy");
                return false;
            }

            

        }

        
    }
}