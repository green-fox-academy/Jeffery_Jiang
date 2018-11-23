using System;
using System.Collections.Generic;
using System.Linq;

namespace CoOrds
{
    class Program
    {
        public struct Cordinate
        {
            public int x;
            public int y;

            public Cordinate(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Cordinate> cordinateList = Fill(20);
            foreach (var VARIABLE in cordinateList)
            {
                Console.WriteLine($"[{VARIABLE.x},{VARIABLE.y}]");
            }
            Cordinate source =new Cordinate(25,25);
            Cordinate cordinateWithMaxDistance = Closest(source, cordinateList);
            Console.WriteLine($"minDistance : [{cordinateWithMaxDistance.x}, {cordinateWithMaxDistance.y}]");

        }

        public static List<Cordinate> Fill(int numOfPoints)
        {
            Random randomX = new Random();
            Random randomY =new Random();
            int x, y;
            List<Cordinate> cordinateList = new List<Cordinate>();

            for (int i = 0; i <= numOfPoints; i++)
            {
                x=randomX.Next(0, 100);
                y=randomY.Next(0, 100);

                cordinateList.Add(new Cordinate(x,y));
            }

            return cordinateList;
        }

        public static Cordinate Closest(Cordinate source,List<Cordinate> cordinates)
        {
            double distance;
            Dictionary<Cordinate,double> myDictionary=new Dictionary<Cordinate, double>();
            foreach (var cordinate in cordinates)
            {
                distance = Math.Sqrt(Math.Pow(cordinate.x - source.x, 2) + Math.Pow(cordinate.y - source.y, 2));
                Console.WriteLine(distance);
                myDictionary.Add(cordinate,distance);
            }

            var max = myDictionary.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            Console.WriteLine("min distance is" +myDictionary.Values.Min().ToString());
            //  quastion is, what if the maxvalue-key pair is not unique;
            return max;
        }
    }
}