using System;
using System.Threading;
using System.Diagnostics;
namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Thread t1 = new Thread(EvenSum);
            Thread t2 = new Thread(OddSum);

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            stopwatch.Stop();

            Console.WriteLine($"Total time in milliseconds: {stopwatch.ElapsedMilliseconds}");
        }
        public static void EvenSum()
        {
            double evensum = 0;
            for(int i=2; i<= 50000000; i+=2)
                evensum += i;
            Console.WriteLine($"Sum of even numbers = {evensum}");
        }
        public static void OddSum()
        {
            double oddsum = 0;
            for(int i=1; i<=50000000; i+= 2)
                oddsum += i;
            Console.WriteLine($"Sum of odd number is = {oddsum}");
        }
    
    }
}
