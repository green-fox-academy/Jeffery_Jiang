using System;

namespace DiceSet
{
    // You have a `DiceSet` class which has a list for 6 dice
    // You can roll all of them with roll()
    // Check the current rolled numbers with getCurrent()
    // You can reroll with reroll()
    // Your task is to roll the dice until all of the dice are 6
    public static class Program
    {
        public static void Main(string[] argv)
        {
            DiceSet diceSet = new DiceSet();
            int position;

            diceSet.GetCurrent();
            diceSet.Roll();
            diceSet.GetCurrent();
            diceSet.GetCurrent(5);
            diceSet.Reroll();
            diceSet.GetCurrent();
            diceSet.Reroll(4);
            diceSet.GetCurrent();

            while (true)
            {
                diceSet.printall();
                if (diceSet.finished())
                {
                    break;
                }
                else
                {
                    Console.WriteLine("which position do you want to reroll or enter 9 to reroll all");
                    
                    position = Convert.ToInt32(Console.ReadLine());
                    if (position == 9)
                    {
                        diceSet.Reroll();
                    }
                    else
                    {
                        diceSet.Reroll(position);
                    }
                    //diceSet.Reroll(position);
                }
            }

            Console.WriteLine("game finished");
            Console.ReadKey();
        }

    }

    public class DiceSet
    {
        private Random randomValue = new Random();
        private int[] dice = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }

            return dice;
        }

        public int[] GetCurrent()
        {
            return dice;
        }

        public int GetCurrent(int i)
        {
            return dice[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            dice[k] = new Random().Next(1, 7);
        }

        public bool finished()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] != 6)
                {
                    return false;
                }
            }

            return true;
        }

        public void printall()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                Console.Write(dice[i]+" ");
            }
            Console.WriteLine("\n");
        }
    }
}