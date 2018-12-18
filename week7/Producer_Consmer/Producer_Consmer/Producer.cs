using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    public class Producer
    {
        public Byte[] DownloadData(string url)
        {
            using (var webClinet = new WebClient())
            {
                return webClinet.DownloadData(url);
            }
        }
    }
}
