using System;
namespace Test
{
    public class Program
    {
        static void  Main(string[] args)
        {
            int a, b, c;
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a/b;
                Console.WriteLine("Value of C is " + c);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HelpLink);
            }
            finally
            {
                Console.WriteLine("Yeah!!!!!");
            }
        }
    }
}
