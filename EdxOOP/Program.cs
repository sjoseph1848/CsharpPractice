using System;
using System.Collections.Generic;

namespace EdXOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("John", "Apple");
            var student2 = new Student("Bob", "Stone");
            var student3 = new Student("Meg", "Jones");
            var teacher1 = new Teacher("John", "Ronaldo");
            var course1 = new Course(101, "Introduction to C#");

            var studentList = new List<Student>();

            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);

            course1.StudentsInCourse(studentList);

            var studentsInCourse = course1.ListOfStudents(studentList);
            

        }
    }
}
