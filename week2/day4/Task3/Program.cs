using System;

namespace Aircraft
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Carrier carrier=new Carrier(2300,5000);
            carrier.add(new Aircraft("F35",12,50));
            carrier.add(new Aircraft("F35",12,50));
            carrier.add(new Aircraft("F35", 12, 50));
            carrier.add(new Aircraft("F16", 8, 30));
            carrier.add(new Aircraft("F16", 8, 30));
            carrier.add(new Aircraft("F16", 8, 30));
            //carrier.fill();
            carrier.getStatus();
            carrier.fill();
            carrier.getStatus();

            Console.ReadKey();


        }
    }
}
