using System;
namespace CustomException
{
    // Creating custom exception class by inheriting Exception class
    public class NegativeNumberException : Exception
    {
        // Overriding the message property
        public override string Message
        {
            get
            {
                return "Number can't be negative";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Please Enter Two Positive Number:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            try
            {
                if(a<0 || b<0)
                {
                    throw new NegativeNumberException();
                }
                c = a / b;
                Console.WriteLine($"The value of C is: {c}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
        }
    }
    
}
