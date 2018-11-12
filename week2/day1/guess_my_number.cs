using System;



namespace GreenFox
{
    class Program
    {
        private static int live = 5;
        static void Main(string[] args)
        {
            Random random= new Random();

            int tar = 20; //random.Next(1, 100);
            int num;

            while (live>0)
            {
                Console.WriteLine("please input a number between 1-100");

                num = Convert.ToInt32(Console.ReadLine());

                if (GuessNum(tar,num))
                {
                    break;
                    
                }
            }

            Console.WriteLine("finished");
            Console.ReadKey();
        }

        static bool GuessNum(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("too small");
                live--;
                Console.WriteLine("live:"+live);
                return false;

            }
            else if(a<b)
            {
                Console.WriteLine("too large");
                live--;
                Console.WriteLine("live:"+live);
                return false;
            }
            else
            {
                Console.WriteLine("you are correct");
                return true;
            }


        }