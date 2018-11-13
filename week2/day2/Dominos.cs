using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            dominoes = OgnizeDominoes(dominoes);
            printList(dominoes);

            Console.ReadKey();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

        public static List<Domino> OgnizeDominoes(List<Domino> list)
        {
            List<Domino> newList= new List<Domino>();
            newList.Add(list[0]);
            list.Remove(list[0]);
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (newList[i].GetValues()[1] == list[j].GetValues()[0])
                    {
                        newList.Add(list[j]);
                        list.Remove(list[j]);
                    }
                }
            }

            return newList;

        }

        public static void printList(List<Domino> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"[{list[i].GetValues()[0]},{list[i].GetValues()[1]}] ");
            }
        }
    }
}