using System;
using System.Collections.Generic;

namespace StudentCounter
{
    public class StudentCounter
    {
        public static void Main(string[] args)
        {
            var map = new List<Dictionary<string, object>>();

            // Given this list of hashmaps...

            var row0 = new Dictionary<string, object>();
            row0.Add("name", "Theodor");
            row0.Add("age", 9.5);
            row0.Add("candies", 2);
            map.Add(row0);

            var row1 = new Dictionary<string, object>();
            row1.Add("name", "Paul");
            row1.Add("age", 10);
            row1.Add("candies", 1);
            map.Add(row1);

            var row2 = new Dictionary<string, object>();
            row2.Add("name", "Mark");
            row2.Add("age", 7);
            row2.Add("candies", 3);
            map.Add(row2);

            var row3 = new Dictionary<string, object>();
            row3.Add("name", "Peter");
            row3.Add("age", 12);
            row3.Add("candies", 5);
            map.Add(row3);

            var row4 = new Dictionary<string, object>();
            row4.Add("name", "Olaf");
            row4.Add("age", 12);
            row4.Add("candies", 7);
            map.Add(row4);

            var row5 = new Dictionary<string, object>();
            row5.Add("name", "George");
            row5.Add("age", 3);
            row5.Add("candies", 2);
            map.Add(row5);

            // Display the following things:
            foreach (Dictionary<string,object> row in map)
            {
                //Console.WriteLine(row.Values);
                if ((int) row["candies"] > 4)
                {
                    Console.WriteLine(row["name"]);
                }
                
            }

            int count=0;
            foreach (Dictionary<string,object> row in map)
            {
                if ((int) row["candies"] < 5)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            Console.ReadKey();
            //  - Who has got more candies than 4 candies
            //  - Sum the age of people who have lass than 5 candies
        }
    }
}