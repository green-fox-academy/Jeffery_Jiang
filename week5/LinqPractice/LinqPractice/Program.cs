using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SomeTest




            string someString = "Jeffery Jiang's Book!! is 123ad!";
            var someArray = someString.ToCharArray();

            var result = someArray.Where(r => !char.IsPunctuation(r));
            #endregion
            #region Exercise1
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenArray = n.Where(r => r % 2 != 0);
            foreach (var num in evenArray)
            {
                Console.WriteLine(num);
            }
            #endregion

            #region Exercise2

            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var n1Output = n1
                .Where(r => r % 2 == 0)
                .Average(r => r);
            Console.WriteLine(n1Output);
            #endregion

            #region Ex3

            var n2Output = n.Where(r => r > 0)
                .Select(r => Math.Pow(r, 2));
            foreach (var d in n2Output)
            {
                Console.WriteLine(d);
            }

            #endregion

            #region Ex4

            int[] n4 = new[] { 3, 9, 2, 8, 6, 5 };

            var n4Output = n4.Where(r => Math.Pow(r, 2) > 20);

            #endregion

            #region Ex5

            int[] n5 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var n5Output = n5
                .GroupBy(r => r);
            foreach (var group in n5Output)
            {
                Console.WriteLine($"Number: {group.Key} appears {group.Count()} times");
            }

            #endregion

            #region Ex6

            string n6 = "hello";
            var n6Output = n6
                .ToCharArray()
                .GroupBy(r => r);
            foreach (var group in n6Output)
            {
                Console.WriteLine($"{group.Key} appears {group.Count()}");
            }

            #endregion

            #region Ex7

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var n7Output = cities.Where(r => r.StartsWith("A")).Where(r => r.EndsWith("I"));

            foreach (var city in n7Output)
            {
                Console.WriteLine(city);
            }
            #endregion

            #region Ex8

            string n8 = "AABBccdd";
            var n8Output = n8.Where(r => (r >= 65 && r <= 90));

            foreach (var variable in n8Output)
            {
                Console.WriteLine(variable);
            }
            #endregion

            #region Ex9

            char[] charArray = { 'H', 'e', 'l', 'l', 'o', '\0' };
            // var n9Output= charArray.

            #endregion

            #region Ex11

            string filePath = "TextFile1.txt";
            var textContainer = File.ReadAllLines(filePath);
            List<string> stringList = new List<string>();


            foreach (var s in textContainer)
            {
                string[] tempList = s.Split(" ");

                foreach (var s1 in tempList)
                {
                    var tempLinqCollection = string.Join("", s1
                        .ToCharArray()
                       // .Where(r=> !char.IsPunctuation(r))
                        .Where(r => r >= 'a' && r <= 'z' || r >= 'A' && r <= 'Z')
                        .ToArray());



                    stringList.Add(tempLinqCollection);
                }
            }

            var n10Output = stringList
                .Where(r => r.Length > 0)  //to ignore "". 
                .GroupBy(r => r)
                .OrderByDescending(r => r.Count());
            foreach (var VARIABLE in n10Output)
            {
                Console.WriteLine($"{VARIABLE.Key} : {VARIABLE.Count()} times");
            }
            #endregion

            #region Ex12 HeaviestMan

            string filePath2 = "swcharacters.txt";
            List<Person> persionList = new List<Person>();

            var lines = File.ReadAllLines(filePath2);

            foreach (var line in lines)
            {
                var information = line.Split(";");
                //to ignore ','

                var pureHeight = string.Join("", information[1]
                    .ToCharArray()
                    .Where(r => r >= 48 && r <= 57)
                    .ToArray());
                var pureMass = string.Join("", information[2]
                    .ToCharArray()
                    .Where(r => r >= 48 && r <= 57)
                    .ToArray());
                var pureAge = string.Join("", information[6]
                    .ToCharArray()
                    .Where(r => r >= 48 && r <= 57 || r == 46)
                    .ToArray());
                int.TryParse(pureHeight, out int height)
                ;

                int.TryParse(pureMass, out int mass);
                double.TryParse(pureAge, out double age);


                Person character = new Person()
                {
                    Name = information[0],
                    Height = height,
                    Mass = mass,
                    Hair_color = information[3],
                    Skin_color = information[4],
                    Eye_color = information[5],
                    Birth_year = age,
                    Gender = information[7]

                };
                persionList.Add(character);
            }

            var orderedByMass = persionList
                .Where(r => r.Mass != 0)
                .OrderByDescending(r => r.Mass)
                .ToList();
            Console.WriteLine($"Heaviest character is {orderedByMass[0].Name} ");

            #endregion

            #region AverageHeightofMal 

            var averageHight = persionList
                .Where(r => r.Gender.ToLower() == "male")
                .Average(r => r.Height);
            Console.WriteLine($"the average of male character is {averageHight} cm");
            // 170.5645
            #endregion

            #region AverageHeightofFemale

            var averageHightF = persionList
                .Where(r => r.Gender.ToLower() == "female")
                .Average(r => r.Height);
            Console.WriteLine($"The average height of female is {averageHightF}");
            #endregion

            #region Age Distribution

            var femaleBelow21 = persionList
                .Where(r => r.Gender == "female")
                .Where(r => r.Birth_year < 21 && r.Birth_year > 0);
            var femaleAbove40 = persionList
                .Where(r => r.Gender == "female")
                .Where(r => r.Birth_year > 40);
            var femaleUnknowAge = persionList
                .Where(r => r.Gender == "female")
                .Where(r => r.Birth_year == 0);
            var ageDistributionDictionary = new Dictionary<string, Dictionary<string, int>>()
            {
                {
                "female", new Dictionary<string,int>()
                    {
                        {"below 21:",femaleBelow21.Count()},
                        {"Above 40",femaleAbove40.Count()},
                        {"unknown", femaleUnknowAge.Count()}
                    }
                }
            };


            #endregion
        }
    }
}
