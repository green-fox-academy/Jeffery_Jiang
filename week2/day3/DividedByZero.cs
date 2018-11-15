using System;

namespace PiratesWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide(10);
            Console.ReadLine();
        }

        static void Divide(int num)
        {
            //Console.WriteLine();
            num = 10;
            int i = int.Parse(Console.ReadLine());

            try
            {
               num= num / i;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("devided by 0");
                //throw;
            }
            //Console.WriteLine(i*2);
        }
    }
}