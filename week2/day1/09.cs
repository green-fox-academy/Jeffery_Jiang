using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            //list.ca

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.


            Sweets(list);
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadKey();
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }

        static void Sweets(List<object> list)
        {
            list[list.IndexOf(2)] = "Croissant";
            list[list.IndexOf(false)] = "Ice cream";

        }
    }
}