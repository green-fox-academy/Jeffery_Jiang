using System;
using System.Collections.Generic;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @".\log.txt";
            //string anotherfilepath = @".\another-file.txt";
            //Console.WriteLine(CopyFile(filepath,anotherfilepath));

           // Console.ReadLine();
            //WriteMultipleLines(filepath,"I love Coding",5);
            List<string> IPAddress = IPaddress(filepath);
            foreach (var IP in IPAddress)
            {
                Console.WriteLine(IP);
            }
            Console.WriteLine(GetPostRatio(filepath));

            Console.ReadKey();

        }

        static List<string> IPaddress(string filename)
        {
            List<string> IPAddress=new List<string>();
            StreamReader reader=new StreamReader(filename);
            string[] informations;
            string[] tempinfor;

            informations=reader.ReadToEnd().Split('/');
            reader.Dispose();
            for (int i = 0; i < informations.Length; i++)
            {

                tempinfor = informations[i].Split(' ');
                if(tempinfor.Length>=8)
                IPAddress.Add(tempinfor[8]);
            }
            

            return IPAddress;

        }

        static double GetPostRatio(string filename)
        {
            StreamReader reader=new StreamReader(filename);
            string[] informations;
            int get = 0;
            int post = 0;
            informations = reader.ReadToEnd().Split('/');
            foreach (var content in informations)
            {
                if (content.Contains("POST"))
                {
                    post++;
                }else if (content.Contains("GET"))
                {
                    get++;
                }
            }

            return get / post;

        }
            

        }

        
    }