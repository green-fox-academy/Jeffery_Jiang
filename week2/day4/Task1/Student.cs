using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Student:Person
    {
        private string previousOrganization;
        private int skippedDays;

        public string PreviousOrganization
        {
            get { return previousOrganization; }
            set { previousOrganization = value;  }
        }

        public int SkippedDays
        {
            get { return skippedDays; }
            set { skippedDays = value; }
        }

        public Student():base()
        {
            previousOrganization = "School of Life";
            skippedDays = 0;
        }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            skippedDays = 0;
            base.Name = name;
            base.Age = age;
            base.Gender = gender;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software engineer");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {base.Name} a {base.Age} year old {base.Gender} from {previousOrganization}," +
                              $" who skipped {skippedDays} days from the course already");
        }

        public void SkipDays(int NumOfDays)
        {
            skippedDays += NumOfDays;
        }
    }
}
