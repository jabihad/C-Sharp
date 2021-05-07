using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HelloWorld
{
    public class Person
    {
        public virtual void Show()
        {
            Console.WriteLine("This is from Base Class Show");
        }
    }
    public class Employee : Person
    {
        public override void Show()
        {
            base.Show(); // Calling base class Show method
            Console.WriteLine("This is from Child class Show");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee E = new Employee();
            E.Show();
        }
    }
}
