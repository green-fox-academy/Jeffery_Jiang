using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Claire", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Tom", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...
            foreach (var VARIABLE in MakingMatches(girls,boys))
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadKey();
        }

        static List<string> MakingMatches(List<string> girls, List<string> boys)
        {
            var conbine = new List<string>();
            //conbine = girls;
            if (girls.Count > boys.Count)
            {
               // conbine = boys;
                for (int i = 0; i < boys.Count; i++)
                {
                    //conbine.Insert(conbine.IndexOf(boys[i]), girls[i]);
                    conbine.Add(girls[i]);
                    conbine.Add(boys[i]);
                }
            }

            if (girls.Count<boys.Count)
            {
                //conbine = girls;
                for (int i = 0; i < girls.Count; i++)
                {
                    //conbine.Insert(conbine.IndexOf(girls[i]),boys[i]);
                    conbine.Add(girls[i]);
                    conbine.Add(boys[i]);
                }
            }

            return conbine;
        }
    }