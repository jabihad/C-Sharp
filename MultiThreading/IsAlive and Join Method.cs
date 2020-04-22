using System.Threading;
using System;
namespace ThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            //Main Thread creating three child threads
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);
            thread1.Start();
            thread2.Start();
            thread3.Start();

            //If we want Main Thread to complete execution after all the child thread have been executed
            thread1.Join();
            thread2.Join();
            thread3.Join();

            //Checking if any thread is still executing
            if (thread1.IsAlive)
                Console.WriteLine("Thread1 Method1 is still doing its work");
            else
                Console.WriteLine("Thread1 Method1 Completed its work");

            //Checking if any thread is executed in given time
            if(thread3.Join(3000))
                Console.WriteLine("Thread 3 Execution Completed in 3 second");
            else
                Console.WriteLine("Thread 3 Execution Not Completed in 3 second");
            
            Console.WriteLine("Main Thread Ended");
        }
        static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            Thread.Sleep(100);
            Console.WriteLine("Method1 - Thread1 Ended");
        }
        static void Method2()
        {
            Console.WriteLine("Method2 - Thread2 Started");
            Thread.Sleep(200);
            Console.WriteLine("Method2 - Thread2 Ended");
        }
        static void Method3()
        {
            Console.WriteLine("Method3 - Thread3 Started");
            Thread.Sleep(500);
            Console.WriteLine("Method3 - Thread3 Ended");
        }
    }
}
