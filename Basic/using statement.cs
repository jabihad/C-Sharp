using System;

namespace Using_Statement
{
    public class Student : IDisposable
    {
        public string Name { get; set; }
        public string Roll { get; set; }
        public void Show()
        {
            Console.WriteLine("Name is {0}\nId is {1}", Name, Roll);
        }
        public void Dispose()       // This comes from IDisposable interface
        {
            Console.WriteLine("Automatically Disposing");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            using (Student s = new Student())
            {
                s.Name = "Jihad";
                s.Roll = "112308545";
                s.Show();
            }
            Console.WriteLine("Out of using scope");
        }
    }
}

//The reason for the using statement is to ensure that
//the object is disposed as soon as it goes out of scope,
//and it doesn't require explicit code to ensure that this happens.
