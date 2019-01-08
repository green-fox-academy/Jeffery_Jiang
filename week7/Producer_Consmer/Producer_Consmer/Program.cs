using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    class Program
    {
        static string filePath = "URLs.txt";
        static void Main(string[] args)
        {
            var producer = new Producer();
            var consumer = new Consumer();
            BlockingCollection<Byte[]> htmlCollection = new BlockingCollection<byte[]>();
            // producer 

            //producer
            var taskList = new List<Task>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string url = "";

                while (url != null)
                {
                    url = reader.ReadLine();
                    if (url != null)
                    {
                        var url1 = url;
                        taskList.Add(Task.Run(() =>
                        {
                            var product = producer.DownloadData(url1);
                            htmlCollection.Add(product);

                        }));
                    }
                }
            }
            //Task.WaitAll(taskList.ToArray());
            //htmlCollection.CompleteAdding();
            // consumer
            //Task.Run(() =>
            //    {
            //        while (!htmlCollection.IsCompleted)
            //        {
            //            try
            //            {
            //                var tokenData = htmlCollection.Take();
            //                consumer.DealingHtml(tokenData);
            //            }
            //            catch (InvalidOperationException)
            //            {
            //                Console.WriteLine("Download finished");
            //                break;
            //            }

            //        }
            //        Console.WriteLine("No more items to take");
            //    }
            //);

            Console.ReadLine();

        }
    }
}

