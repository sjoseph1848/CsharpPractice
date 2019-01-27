using System;
using System.Collections.Generic;
using System.Text;

namespace EdXOOP
{
    public class Student
    {
        private static int count = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            count++;
        }
        //student.CountStudents();
        public static int CountStudents()
        {
            return count;
        }
    }
}
