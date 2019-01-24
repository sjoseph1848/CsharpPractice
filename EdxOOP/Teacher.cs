using System;
using System.Collections.Generic;
using System.Text;

namespace EdXOOP
{
    public class Teacher
    {
       
        private string _name;
        

        public Teacher(string Name)
        {
            if(Name == "John Doe")
            {
                _name = Name;
               
            }
        }

        public string Available()

        public string SubjectTaught(Course course)
        {
            course = "Introduction to C#";
            return course;
        }

    }
}
