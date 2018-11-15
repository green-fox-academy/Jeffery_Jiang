using System;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Garedn garedn=new Garedn();
            garedn.Trees.Add(new Tree("purple",0));
            garedn.Trees.Add(new Tree("orange",0));
            garedn.Flowers.Add(new Flower("yellow",0));
            garedn.Flowers.Add(new Flower("blue",0));

            int amount=40;

            
            garedn.Status();
            garedn.Watering(amount);
            garedn.Watering(70);

            Console.ReadKey();


        }
    }
}
