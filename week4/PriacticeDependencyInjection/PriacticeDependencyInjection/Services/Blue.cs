using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriacticeDependencyInjection.Services
{
    public class Blue:IColor
    {
        private readonly string color = "blue";

        public void PrintColor()
        {
            Console.WriteLine($"It is {color} in color");
        }
    }
}
