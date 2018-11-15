using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApp
{
    class Flower
    {
        private string color;
        private double waterAmount;
        //private bool needWater;

        public string Color { get => color; set => color = value; }
        public double WaterAmount { get => waterAmount; set => waterAmount = value; }

        public bool NeedWater
        {
            get
            {
                if (WaterAmount < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Flower(string color, int waterAmount)
        {
            Color = color;
            WaterAmount = waterAmount;
            
        }

        public void Watering(double amount)
        {
                WaterAmount += amount * 0.75;
            
        }

        
        public void Status()
        {
            if (NeedWater)
            {
                Console.WriteLine($"The {Color} flower needs water");
               // Statu = true;
                //return true;
            }
            else
            {
                Console.WriteLine($"The {Color} flower doesnot need water");
               // return false;
            }
        }
    }
}
