using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            planetList.Insert(planetList.IndexOf("Uranus"),"Saturn");
            
            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"

            Console.ReadKey();
        }

        static StringBuilder PutSaturn(List<string> planeList)
        {
            StringBuilder planetString = new StringBuilder();


            foreach (var planet in planeList)
            {
                planetString.Append(planet);
            }

            return planetString;


        }
   
        

    }
}