using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.IO;

namespace Fileloggertest
{
    class NetworkAndFileloger:Filelogger
    {
        private readonly HttpClient httpClient;

        public NetworkAndFileloger(string filepath) : base(filepath)
        {
            httpClient=new HttpClient();
        }

        public override void Log( string massage)
        {
           httpClient.PostAsync("http://requestbin.fullcontact.com/1e517781", new StringContent(massage)).Wait();

            
        }
    }
}
