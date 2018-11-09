using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array
            string[][] color = {
                new string[] {"Lime", "forest green", "olive", "pale green", "spring green"},
                new string[]{"orange", "tomato"},
                new string[]{"orchid","violet"} };

            Console.WriteLine(color[1][1]);
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
            Console.ReadLine();
        }
    }
}