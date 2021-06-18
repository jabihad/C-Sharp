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
            var querySyntax = from student in Student.GetAllStudents()
                              join address in Address.GetAllAddresses()
                              on student.AddressId equals address.Id
                              join department in Department.GetAllDepartments()
                              on student.DepartmentId equals department.Id
                              select new
                              {
                                  StudentName = student.Name,
                                  Department = department.Name,
                                  Road = address.Street
                              };
            foreach (var student in querySyntax)
            {
                Console.WriteLine(student.StudentName + " " + student.Department + " " + student.Road);
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int AddressId { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { Id = 1, Name = "Preety", DepartmentId = 1, AddressId = 1 },
                new Student { Id = 2, Name = "Priyanka", DepartmentId = 2, AddressId = 2 },
                new Student { Id = 3, Name = "Anurag", DepartmentId = 1, AddressId = 3 },
                new Student { Id = 4, Name = "Pranaya", DepartmentId = 4, AddressId = 4 },
                new Student { Id = 5, Name = "Hina", DepartmentId = 1, AddressId = 5 },
                new Student { Id = 6, Name = "Sambit", DepartmentId = 2, AddressId = 6 },
                new Student { Id = 7, Name = "Happy", DepartmentId = 3, AddressId = 7},
                new Student { Id = 8, Name = "Tarun", DepartmentId = 4, AddressId = 8 },
                new Student { Id = 9, Name = "Santosh", DepartmentId = 3, AddressId = 9 },
                new Student { Id = 10, Name = "Raja", DepartmentId = 2, AddressId = 10},
                new Student { Id = 11, Name = "Sudhanshu", DepartmentId = 2, AddressId = 11}
            };
        }
    }
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public static List<Address> GetAllAddresses()
        {
            return new List<Address>()
            {
                new Address { Id = 1, Street = "Lane 1"},
                new Address { Id = 2, Street = "Lane 1"},
                new Address { Id = 3, Street = "Lane 13"},
                new Address { Id = 4, Street = "Lane 14"},
                new Address { Id = 5, Street = "Lane 1"},
                new Address { Id = 9, Street = "Lane 1"},
                new Address { Id = 10, Street = "Lane 110"},
                new Address { Id = 11, Street = "Lane 111"},
            };
        }
    }
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>
            {
                new Department(){Id = 1, Name = "CSE"},
                new Department(){Id = 2, Name = "Physics"},
                new Department(){Id = 3, Name = "Math"},
                new Department(){Id = 4, Name = "Chemsitry"},
                new Department(){Id = 5, Name = "Biology"},
                new Department(){Id = 6, Name = "Stat"},
            };
        }
    }
}
