using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;


        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public int HiredStudents
        {
            get { return hiredStudents; }
            set { hiredStudents = value; }
        }
        public Sponsor() : base()
        {
            Company = "Google";
            HiredStudents = 0;
        }
        public Sponsor(string name, int age, string gender, string company)
        {
            base.Name = name;
            base.Age = age;
            base.Gender = gender;
            Company = company;
            HiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} a {Age} year old {Gender} who represents {company} and hired {hiredStudents}" +
                              $"so far");
        }

        public void Hire()
        {
            hiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers");
        }

    }
}