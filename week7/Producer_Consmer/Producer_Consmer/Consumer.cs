using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Producer_Consumer
{
    class Consumer
    {
        //    private readonly HtmlContext htmlContext;

        //public Consumer(HtmlContext htmlContext)
        //{
        //    this.htmlContext = htmlContext;
        //}

        public void DealingHtml(Byte[] input)
        {
            var htmlString = System.Text.Encoding.Default.GetString(input);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            var htmlBody = doc.DocumentNode.SelectNodes("//body");
            Console.WriteLine($"{Task.CurrentId}task comsumer finished ");

        }
    }
}
