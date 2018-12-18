using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    class Program
    {
        private static string filePath = "URLs.txt";
        static void Main(string[] args)
        {
            var producer = new Producer();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string url = "";
                while (url != null)
                {
                    url = reader.ReadLine();
                    var producerTask = Task.Factory.StartNew<Byte[]>(() => producer.DownloadData(url));
                    //foreach (var b in producerTask.Result)
                    //{
                    //    Console.Write(Encoding.Default.GetString(producerTask.Result));
                    //}
                }



            }




        }
    }
}
