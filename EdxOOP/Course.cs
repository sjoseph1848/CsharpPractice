using System;
using System.Collections.Generic;
using System.Text;

namespace EdXOOP
{
    public class Course
    {
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public int StudentCount { get; set; }

        public Course(int courseNumber,string courseName)
        {
            this.CourseNumber = courseNumber;
            this.CourseName = courseName;
    
        }       
        public void StudentsInCourse(List<Student> studs)
        {
            foreach (Student s in studs)
            {
                Console.WriteLine(s.FirstName);
            }
        }

        public static List<Object> ListOfStudents(List<Student> studs)
        {
            var studList = new List<object>();
            foreach (Student s in studs)
            {
                var studName = s.FirstName + " " + s.LastName; 
                studList.Add(studName);
            }
            return studList;
        }


    }
}
