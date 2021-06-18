using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //// Example 1 
            List<string> nameList = new List<string>() { "Kamal", "Ahmed" };

            IEnumerable<char> querySyntax1 = from str in nameList
                                             from ch in str
                                             select ch;
            IEnumerable<char> methodSyntax1 = nameList.SelectMany(x => x);

            //// Example 2
            List<string> methodSyntax2 = Student.GetStudents().SelectMany(std => std.Programming).ToList();

            IEnumerable<string> querySyntax2 = from std in Student.GetStudents()
                                               from program in std.Programming
                                               select program;
            //// Example 3
            List<string> methodSyntax3 = Student.GetStudents()
                                        .SelectMany(std => std.Programming)
                                        .Distinct()
                                        .ToList();

            IEnumerable<string> querySyntax3 = (from std in Student.GetStudents()
                                                from program in std.Programming
                                                select program).Distinct().ToList();

            //// Example 4
            var methodSyntax4 = Student.GetStudents()
                                        .SelectMany(std => std.Programming,
                                             (student, program) => new
                                             {
                                                 StudentName = student.Name,
                                                 ProgramName = program
                                             }
                                             )
                                        .ToList();

            var querySyntax4 = (from std in Student.GetStudents()
                                from program in std.Programming
                                select new
                                {
                                    StudentName = std.Name,
                                    ProgramName = program
                                }).ToList();
            foreach (var item in methodSyntax4)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }

        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"} },
                new Student(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Student(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Java", "LINQ"} },
                new Student(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }
    }
}
