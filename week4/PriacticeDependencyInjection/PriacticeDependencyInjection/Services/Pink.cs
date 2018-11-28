using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriacticeDependencyInjection.Services
{
    public class Pink:IColor
    {
        private readonly string color="pink";
        public void PrintColor()
        {
            Console.WriteLine($"It is {color} in color");
        }
    }
}
