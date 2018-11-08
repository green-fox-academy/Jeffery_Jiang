using System;

namespace ConsoleApp1
{
   

    class Sum


    {
       

        static void Main(string[] args)

        {
            int sum = 0;
            int x;
            int count = 0;
            int average = 0;
            while (true)
            {
                //int num = 9;
                Console.WriteLine("please enter a int :");
               x = Convert.ToInt32(Console.ReadLine());
                count++;

                sum += x;
                average = sum / count;

                Console.WriteLine("the sum is " + sum + " the average is " + average);





               

                
                ;
            }
        }

        
           
        


    }
}
