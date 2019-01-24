using System;

namespace EdXOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sam = new Student();
            var joe = new Student();
            var jim = new Student();

            var Teacher = new Teacher("John Doe");
            

            Console.WriteLine(EdXOOP.Student.count);
        }
    }
}
