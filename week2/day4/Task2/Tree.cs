using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Tree
    {
        private string color;
        private double waterAmount;
        public string Color { get => color; set => color = value; }
        public double WaterAmount { get => waterAmount; set => waterAmount = value; }

        public bool NeedWater
        {
            get
            {
                if (WaterAmount < 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public Tree(string color, double waterAmount)
        {
            this.color = color;
            this.waterAmount = waterAmount;
        }

        public void Watering(double amount)
        {
           
                WaterAmount += amount * 0.4;
            
        }

        public void Status()
        {
            if ( NeedWater)
            {
                Console.WriteLine($"The {Color} Tree needs water");
            }
            else
            {
                Console.WriteLine($"The {Color} Tree doesnot need water");
            }
            
        }
    }
}
