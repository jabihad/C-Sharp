using System;
using System.Threading;
namespace Test
{
    class Program
    {
        static object lockObject = new object();
        public static void Show()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to enter into the critical section");
            Monitor.Enter(lockObject);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " entered into the critical section");
                for(int i = 0; i<5; i++)
                {
                    Console.Write(i);
                    if(i<4)
                       Console.Write(", ");
                
                }
                Console.WriteLine();
                    
            }
            finally
            {
                Monitor.Exit(lockObject);
                Console.WriteLine(Thread.CurrentThread.Name + " exited from critical section");
            }
        }
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for(int i=0; i<3; i++)
            {
                threads[i] = new Thread(Show);
                threads[i].Name = "Child Thread " + i;
            }

            foreach(Thread t in threads)
                t.Start();
        }

    }
}
