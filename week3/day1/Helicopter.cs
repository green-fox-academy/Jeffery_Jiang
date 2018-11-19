using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    class Helicopter:Vehicle,IFlyable
    {
        public Helicopter(string name,int prize)
        {
            base.name = name;
            size = "large";
            this.prize = prize;
        }
        public void Land()
        {
            Console.WriteLine("I am landing");
        }

        public void Fly()
        {
            Console.WriteLine("I am flying");
        }

        public void TakeOff()
        {
            Console.WriteLine("I am taking off");
            throw new NotImplementedException();
        }
    }
}
