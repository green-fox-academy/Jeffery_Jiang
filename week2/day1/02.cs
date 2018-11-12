using System;
using System.Linq;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            url=url.Replace("bots", "odds");
            /*
            string[] urlSplit = url.Split('/');

            url = string.Join("//", urlSplit);
            */
            url=url.Insert(url.LastIndexOf("//"), ":");
        
            // another method

            Console.WriteLine(url.LastIndexOf("//"));



            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            Console.WriteLine(url);
            Console.ReadKey();
        }
    }
}