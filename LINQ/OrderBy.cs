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

            var methodSyntax = Student.GetStudents()                         // Type is IOrderedEnumerable<Student>
                               .Where(std => std.Gender.ToUpper() == "MALE" || std.Gender.ToUpper() == "FEMALE")
                               .OrderBy(x => x.Name)                         //.OrderByDescending(x => x.Name). Will be ordered by descending
                               .ThenByDescending(x => x.Salary)
                               .ThenBy(x => x.Gender);
                                
                                                                             
            
            var querySyntax =  from student in Student.GetStudents()
                               where student.Gender.ToUpper() == "MALE"      // Type is IOrderedEnumerable<Student>
                               orderby student.Name,                         // ascending is optional
                                       student.Salary descending,
                                       student.Gender ascending
                               select student;                               
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item.Name);
            }
        }
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }
            public List<string> Technology { get; set; }
            public static List<Student> GetStudents()
            {
                List<Student> students = new List<Student>()
                {
                    new Student {ID = 101, Name = "Preety", Gender = "Female", Salary = 60000, Technology = new List<string>() {"C#", "Jave", "C++"} },
                    new Student {ID = 102, Name = "Priyanka", Gender = "Female", Salary = 50000, Technology =new List<string>() { "WCF", "SQL Server", "C#" } },
                    new Student {ID = 103, Name = "Anurag", Gender = "Female", Salary = 40000, Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                    new Student {ID = 104, Name = "Anurag", Gender = "Male", Salary = 450000, Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                    new Student {ID = 105, Name = "Sambit", Gender = "Male", Salary = 550000, Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                    new Student {ID = 106, Name = "Sushanta", Gender = "Male", Salary = 700000, Technology =new List<string>() { "ADO.NET", "C#", "LINQ" }}
                };
                return students;
            }
        }
    }
}
