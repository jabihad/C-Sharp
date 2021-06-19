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
        // Linq's Join is equivalent to SQL's Inner Join
        // Linq's GroupJoin is equivalent to SQL's Outer Join
        // Left Outer Join and Right Outer Join can be performed by exchanging data source
        // Cross Join doesn't require common property. It generates cartesian products of the collection

            var joinQuerySyntax = from dept in Department.GetAllDepartments()
                                  join std in Student.GetAllStudents()
                                  on dept.ID equals std.DepartmentId
                                  select new { Name = std.Name, Department = dept.Name };
            //foreach(var std in joinQuerySyntax)
            //{
            //    Console.WriteLine(std.Name + " " + std.Department);
            //}

            var groupJoinQuerySyntax = from dept in Department.GetAllDepartments()
                                       join std in Student.GetAllStudents()
                                       on dept.ID equals std.DepartmentId
                                       into StudentGroups         // List of children. Here it is list of Student
                                       select new { Department = dept.Name, StudentGroups = StudentGroups };
                                       // from p in Parent
                                       // join c in Child
                                       // on p.Id equals c.Id into GROUPJOIN
                                       // select new { NewParent = Parent, NewChildren = GROUPJOIN};
                                       // NewChildren is a list of Children. It can be empty if there is no children

            //Outer Foreach is for all department
            //foreach (var item in groupJoinQuerySyntax)
            //{
            //    Console.WriteLine("Department :" + item.Department);
            //    //Inner Foreach loop for each student of a department
            //    foreach (var student in item.StudentGroups)
            //    {
            //        Console.WriteLine("  StudentID : " + student.Id + " , Name : " + student.Name);
            //    }
            //}
            var flattenedQuerySyntax = from dept in Department.GetAllDepartments()
                                       join std in Student.GetAllStudents()
                                       on dept.ID equals std.DepartmentId
                                       into StudentGroups
                                       from student in StudentGroups.DefaultIfEmpty()
                                       select new { Department = dept, StudentName = student?.Name };

            //foreach(var item in flattenedQuerySyntax)
            //{
                //Console.WriteLine("Department - " + item.Department.Name + " . Student - " + item.StudentName);
            //}



            var crossJoin = from std in Student.GetAllStudents()
                            from dept in Department.GetAllDepartments()
                            select new
                            {
                                Name = std.Name,
                                Depatment = dept.Name
                            };
            
            Console.WriteLine(crossJoin.LongCount()); // Number of Student * Number of Department
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student { Id = 1, Name = "Preety", DepartmentId = 10},
                new Student { Id = 2, Name = "Priyanka", DepartmentId =20},
                new Student { Id = 3, Name = "Anurag", DepartmentId = 30},
                new Student { Id = 4, Name = "Pranaya", DepartmentId = 30},
                new Student { Id = 5, Name = "Hina", DepartmentId = 20},
                new Student { Id = 6, Name = "Sambit", DepartmentId = 10},
                new Student { Id = 7, Name = "Happy", DepartmentId = 10},
                new Student { Id = 8, Name = "Tarun", DepartmentId = 0},
                new Student { Id = 9, Name = "Santosh", DepartmentId = 10},
                new Student { Id = 10, Name = "Raja", DepartmentId = 20},
                new Student { Id = 11, Name = "Ramesh", DepartmentId = 30}
            };
        }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { ID = 10, Name = "IT"},
                new Department { ID = 20, Name = "HR"},
                new Department { ID = 30, Name = "Sales"},
                new Department { ID = 31, Name = "Fao"},
            };
        }
    }
}
