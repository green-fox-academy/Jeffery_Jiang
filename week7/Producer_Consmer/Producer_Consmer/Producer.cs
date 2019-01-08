using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    public class Producer
    {
        public Byte[] DownloadData(string url)
        {
            Console.WriteLine($"Downloading: {url} current TaskId{Thread.CurrentThread.ManagedThreadId}");
            using (var webClinet = new WebClient())
            {
                Console.WriteLine($"{url}download finished");
                return webClinet.DownloadData(url);
            }
            
        }
    }
}
