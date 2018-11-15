using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age;}
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public Person(string name, int age, string gender) 
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'am {name}, a {age} years old {gender}");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is living for a moment");
        }
    }
}
