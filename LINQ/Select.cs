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
            //////// Select All Property of Student
            
            var querySyntax1 = (from std in Student.GetStudents()
                                select std).ToList();
            var methodSyntax1 = Student.GetStudents().ToList();

            //////// Select Single Property of Student
            
            var querySyntax2 = (from std in Student.GetStudents()
                                select std.ID).ToList();
            var methodSyntax2 = Student.GetStudents().Select(emp => emp.ID);

            //////// Select Multiple Property of Student
            
            var querySyntax3 = (from std in Student.GetStudents()
                                select new Student()
                                {
                                    FirstName = std.FirstName,
                                    LastName = std.LastName
                                }).ToList();
            var methodSyntax3 = Student.GetStudents().
                                Select(std => new Student()
                                {
                                    FirstName = std.FirstName,
                                    LastName = std.LastName
                                }).ToList();
            //////// Select Multiple Property of Student to another New Class
            
            var querySyntax4 = (from std in Student.GetStudents()
                                select new StudentInfo()
                                {
                                    FirstName = std.FirstName,
                                    LastName = std.LastName
                                }).ToList();
            var methodSyntax4 = Student.GetStudents().
                                Select(std => new StudentInfo()
                                {
                                    FirstName = std.FirstName,
                                    LastName = std.LastName
                                }).ToList();

            //////// Select Multiple Property of Student to Anonymous Type
            
            var querySyntax5 = (from std in Student.GetStudents()
                                select new
                                {
                                    FirstName = std.FirstName + " World ", // Can perform manipulation
                                    LastName = std.LastName
                                }).ToList();
            var methodSyntax5 = Student.GetStudents().
                                Select(std => new
                                {
                                    FirstName = std.FirstName + " World ",
                                    LastName = std.LastName
                                }).ToList();

            //////// Select data with index value
            
            var querySyntax6 = (from std in Student.GetStudents().Select((value, index) => new { value, index })
                                select new
                                {
                                    IndexPosition = std.index,
                                    FullName = std.value.FirstName + " " + std.value.LastName,
                                }).ToList();

            var methodSyntax6 = Student.GetStudents().
                                Select((std, index) => new
                                {
                                    IndexPosition = index,
                                    FullName = std.FirstName + " " + std.LastName,
                                }).ToList();

            foreach (var emp in methodSyntax6)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName}");
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student {ID = 101, FirstName = "Kamal", LastName = "Chowdhury"},
                new Student {ID = 102, FirstName = "Shafiq", LastName = "Ahmed"},
                new Student {ID = 103, FirstName = "Hina", LastName = "Khan"},
                new Student {ID = 104, FirstName = "Subrata", LastName = "Mohanty"},
                new Student {ID = 105, FirstName = "Rakib", LastName = "Khan"},
                new Student {ID = 106, FirstName = "Sushanta", LastName = "Dev"}
            };
            return students;
        }
    }
    public class StudentInfo
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
