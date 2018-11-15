using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Garedn
    {
        private List<Flower> flowers;
        private List<Tree> trees;
        
        internal List<Flower> Flowers { get => flowers; set => flowers = value; }
        internal List<Tree> Trees { get => trees; set => trees = value; }

        public Garedn()
        {
            flowers=new List<Flower>();
            trees=new List<Tree>();
        }

        public void Status()
        {
            foreach (var flower in Flowers)
            {
               // Console.WriteLine(flower.Status());
                flower.Status();
            }

            foreach (var tree in Trees)
            {
                tree.Status();
            }
        }

        public void Watering(double amount)
        {
            int numofflowersneedwater = 0;
            int numoftreesneedwater = 0;
            Console.WriteLine($"Watering with {amount}");
            double per;
            foreach (var flower in Flowers)
            {
                if (flower.NeedWater)
                {
                    numofflowersneedwater++;
                }
            }

            foreach (var tree in Trees)
            {
                if (tree.NeedWater)
                {
                    numoftreesneedwater++;
                }
            }

            per = amount / (numoftreesneedwater + numofflowersneedwater);

            foreach (var flower in Flowers)
            {
               // flower.Status();
                if (flower.NeedWater)
                {
                    flower.Watering(per);
                }
            }

            foreach (var tree in Trees)
            {
                //tree.Status();
                if (tree.NeedWater)
                {
                    tree.Watering(per);
                }
            }
            Status();
        }
    }
}
