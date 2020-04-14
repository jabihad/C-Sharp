using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            // try and finally block must be executed
            // The catch block which matches with exception , will be executed only
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("VALUE of C is = " + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HelpLink);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HelpLink);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
            Console.ReadKey();
        }
    }
}
