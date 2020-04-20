using System.Threading;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Thread t1 = new Thread(Display);
            t1.Start();*/
            // Thread class constructor takes delegate as parameter
            // Following is the equivalent of above

            // Creating ThreadStart delegate by passing method name as a parameter to its constructor
            ThreadStart obj = new ThreadStart(Display);

            // Passing ThreadStart delegate instance as a parameter
            Thread t1 = new Thread(obj);
            t1.Start();
        }
        static void Display()
        {
            for(int i=1; i<=5; i++)
            {
                Console.WriteLine("Method1 : " + i);
            }

        }
    }
}
