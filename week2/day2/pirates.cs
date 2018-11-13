using System;

namespace PiratesWar
{
    public class Pirates
    {
        private int status=0;

        public void DrinkSomeRum()
        {
            if (status != -1)
            {
                Console.WriteLine("aha It is so nice!");
                status += 1;
            }
            else
            {
                Console.WriteLine("the pirates is already dead.");
            }
            //return;
            
        }

        public void HowIsGoingonMate()
        {

            if (status <= 4)
            {
                Console.WriteLine("Pour me anudder!");
               // Console.Read();
                Console.WriteLine(@"Will you give him some Rum? (enter 'yes' to offer or 'no' to not offer)");
                if (Console.ReadLine() == "yes")
                {
                    DrinkSomeRum();
                }
                else if(Console.ReadLine()=="no")
                {
                    Console.WriteLine("leave me alone!");
                    return;
                    
                }
                else
                {
                    return;
                    
                }
            }
            else if(status==-1)
            {
                Console.WriteLine("the pitate is already dead.");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                status = 0;
            }
            return;
            
        }

        public void Die()
        {
            status = -1;
        }

        public void Brawl(Pirates pirates)
        {
            int a= new Random().Next(1,4);
            if (a == 1)
            {
                this.Die();
                Console.WriteLine("your pirate lost the battle");
            }
            else if(a==2)
            {   
                Console.WriteLine("your pirates wins the battle!");
                pirates.Die();
            }
            else
            {
                Console.WriteLine("I am sorry to tell you both of them are passed out.");
                Die();
                pirates.Die();
            }
        }

    }
}