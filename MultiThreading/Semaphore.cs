using System;
using System.Threading;
namespace Test
{
    class Program
    {
        private static Semaphore semaphore = new Semaphore(2, 3);
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];
            for(int i=0; i<5; i++)
            {
                threads[i] = new Thread(Show);
                threads[i].Name = "Thread " + i;
            }
            foreach(Thread t in threads)
            {
                t.Start();
            }
        }
        public static void Show()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " wants to enter critical section for processing");
            try
            {
                semaphore.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is processing now");
                Thread.Sleep(1000);
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " has completed its task");
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
