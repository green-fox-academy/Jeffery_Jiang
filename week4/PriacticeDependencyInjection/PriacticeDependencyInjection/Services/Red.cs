using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriacticeDependencyInjection.Services
{
    public class Red:IColor
    {
        private readonly string color = "red";
        public void PrintColor()
        {
            Console.WriteLine($"It is {color} in color");
        }
    }
}
