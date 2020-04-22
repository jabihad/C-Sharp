using System.Threading;
using System;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Show)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Show)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Show)
            {
                Name = "Thread3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
        }
        private static object lo = new object();
        static void Show()
        {
            //The block we want to protect should be placed inside the lock block
            lock(lo)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" Started");
                Console.Write("Hello ");
                Thread.Sleep(1000);
                Console.WriteLine("World!");
                Console.WriteLine(Thread.CurrentThread.Name+" Ended");
            }
        }
    }
}
