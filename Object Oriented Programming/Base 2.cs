using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HelloWorld
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("In Parent()");
        }
        public Parent(int i)
        {
            Console.WriteLine("In Parent(int i)");
        }
    }
    public class Child : Parent
    {
        // This constructor will call Parent.Parent()
        public Child() : base()
        {

        }

        // This constructor will call Parent.Parent(int i)
        public Child(int i) : base(i)
        {

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Child c = new Child();
            Child d = new Child(1);
        }
    }
}
