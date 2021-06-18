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
         ///// Example 1
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> methodSyntax1 = intList.Where(num => num > 5);

            IEnumerable<int> querySyntax1 = from num in intList
                                            where num > 5
                                            select num;
         ///// Example 2
            var querySyntax2 = from number in intList.Select((num, index) => new { Numbers = num, IndexPosition = index })
                               where number.Numbers % 2 != 0
                               select new
                               {
                                   Number = number.Numbers,
                                   IndexPosition = number.IndexPosition
                               };

            var methodSyntax2 = intList.Select((num, index) => new
                                        {
                                            Numbers = num,
                                            IndexPosition = index
                                        })
                                        .Where(x => x.Numbers % 2 != 0)
                                        .Select(data => new
                                        {
                                            Number = data.Numbers,
                                            IndexPosition = data.IndexPosition
                                        });
         ///// Example 3
            var querySyntax3 = (from student in Student.GetStudents()
                               where student.Salary >= 50000 && student.Technology != null
                               select new
                               {
                                   StudentName = student.Name,
                                   Gender = student.Gender,
                                   MonthlySalary = student.Salary / 12
                               }).ToList();

            var methodSyntax3 = Student.GetStudents()
                                       .Where(student => student.Salary >= 50000 && student.Technology != null)
                                       .Select(student => new {
                                              EmployeeName = student.Name,
                                              Gender = student.Gender,
                                              MonthlySalary = student.Salary / 12
                                        })
                                        .ToList();
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
                    new Student {ID = 103, Name = "Hina", Gender = "Female", Salary = 40000, Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                    new Student {ID = 104, Name = "Anurag", Gender = "Male", Salary = 450000, Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                    new Student {ID = 105, Name = "Sambit", Gender = "Male", Salary = 550000, Technology =new List<string>() { "MVC", "Jave", "LINQ"}},
                    new Student {ID = 106, Name = "Sushanta", Gender = "Male", Salary = 700000, Technology =new List<string>() { "ADO.NET", "C#", "LINQ" }}
                };
                return students;
            }
        }
        public static bool EvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
