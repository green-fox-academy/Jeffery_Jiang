using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Mentor:Person
    {
        private string level;

        public Mentor() :base()
        {
            level = "intermediate";
        }

        public Mentor(string name, int age, string gender,string level)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }

        public string Level { get => level; set => level = value; }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developer");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor");
        }

    }
}
