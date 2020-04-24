using System;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;

            Calculator obj = new Calculator();

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            res = obj.Add(a, b);
            Console.WriteLine($"Sum of {a} and {b} is {res}");

            res = obj.Subtract(a, b);
            Console.WriteLine($"Subtraction from {a} to {b} is {res}");
        }
    }
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
