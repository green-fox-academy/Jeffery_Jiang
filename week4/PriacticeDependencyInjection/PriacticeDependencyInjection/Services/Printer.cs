using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriacticeDependencyInjection
{
    public class Printer
    {
        public void log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
}
