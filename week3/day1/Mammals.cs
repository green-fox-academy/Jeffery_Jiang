using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Mammals:Aminal
    {
        public Mammals(string name)
        {
            base.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public override void Eat()
        {
            Console.WriteLine("I eat meat and vegetables");
        }

        public override string Size()
        {
            return "big";

        }

        public override void Greet()
        {
            Console.WriteLine($"Hello I am a {name} I eat");
        }

        public override void WantChild()
        {
            throw new NotImplementedException();
        }
    }
}
