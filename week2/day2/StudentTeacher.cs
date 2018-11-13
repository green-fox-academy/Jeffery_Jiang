using System;

namespace StudentandTeacher
{
    class Student
    {
        public void learn()
        {
            return;
            
        }

        public void question(Teacher teacher)
        {
            teacher.answer();
            
        }
    }

    class Teacher
    {
        public void answer()
        {
            return;
            
        }

        public void teach(Student student)
        {
            student.learn();
            
        }
    }
}