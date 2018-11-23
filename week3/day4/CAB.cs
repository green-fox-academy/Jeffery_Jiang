using System;
using System.Collections.Generic;
using System.Text;

namespace CAB
{
   public class CowsAndBulls
    {
        private const bool playing = true;
        private const bool finished = false;
        public int GuessCount { get; private set; }
        private const int NumToGuess = 4;
        private const int MinNumToGuess = 1;
        private const int MaxNumToGuess = 20;
        public bool game_status;
        private int remainGuess;
        public int Count { private set; get; }
        public int Number { get; private set; }
        public int Position { get; private set; }
        private readonly Dictionary<int, int> cabDictionary;
        public CowsAndBulls()
        {
            cabDictionary=new Dictionary<int, int>();
            GenerateGame(ref cabDictionary);
            game_status = playing;
            remainGuess = 4;

        }

        private void GenerateGame(ref Dictionary<int,int> parDictionary)
        {
            Random randomNum= new Random();
            for (int i = 0; i <= NumToGuess; i++)
            {
               parDictionary.Add(i,randomNum.Next(1,20));
            }

        }

        public string Guess(int position, int num)
        {
            GuessCount++;
            if (cabDictionary.ContainsValue(num))
            {
                int result;
                if (cabDictionary.Count <= 0)
                {
                    game_status = finished;
                }
                
                if (cabDictionary.TryGetValue(position, out result))
                {
                    if (result ==num)
                    {
                        cabDictionary.Remove(position);
                        return "Cow";
                    }
                    else
                    {
                        foreach (var keyvaluepair in cabDictionary)
                        {
                            if (keyvaluepair.Value == num)
                            {
                                int currentposition = keyvaluepair.Key;
                                cabDictionary.Remove(currentposition);
                                break;
                                
                            }
                        }
                        
                        return "Bull";
                    }
                }
                else
                {
                    Console.WriteLine("position is out of range");
                    return null; 
                }
            }
            else
            {
                return "Try Again";
            }
        }
    }
}
