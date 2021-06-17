using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var student1 = Get();             // directly accessing Static Get method
            Console.WriteLine(student1.Id);   // 1
            Console.WriteLine(student1.Name); // Kamal

            var obj = new Program();          // creating object
            var student2 = obj.Send();        // then accessing non Static Send method
            Console.WriteLine(student2.Id);   // 2
            Console.WriteLine(student2.Name); // Rafiq

        }
        public static Student Get() // Can use this method from main method directly
        {
            return new Student() { Id="1", Name="Kamal"};
        }
        public Student Send()      // Can't use this method from main method directly. We have
        {                          // to create an object in main method to access it

            return new Student() { Id = "2", Name = "Rafiq" };
        }
    }
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
