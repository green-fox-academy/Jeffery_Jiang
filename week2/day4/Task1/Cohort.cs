using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Cohort
    {
        private string name;
        private List<Student> studentses ;
        private List<Mentor> mentors ;

        public string Name { get => name; set => name = value; }
        public List<Student> Studentses { get => studentses; set => studentses = value; }
        public List<Mentor> Mentors { get => mentors; set => mentors = value; }

        public Cohort(string name)
        {
            Name = name;
            studentses = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            
            Studentses.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {name} cohort has {Studentses.Count} students and {Mentors.Count} mentors");
        }
    }
}
