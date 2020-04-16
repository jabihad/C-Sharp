using System.Threading;
using System;

namespace MultiThreading
{
    class Program
    {
        static void method1()
        {
            Console.WriteLine("Method1 started using " + Thread.CurrentThread.Name);
            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine("Method1 : " + i);
            }
            Console.WriteLine("Method1 ended using " + Thread.CurrentThread.Name);

        }
        static void method2()
        {
            Console.WriteLine("Method2 started using " + Thread.CurrentThread.Name);
            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine("Method2 : " + i);
                if(i==3)
                {
                    Console.WriteLine("Performing the Database operation started");
                    Thread.Sleep(10000);
                    Console.WriteLine("Database operation ended");
                }
                
            }
            Console.WriteLine("Method2 ended using " + Thread.CurrentThread.Name);
        }
        static void method3()
        {
            Console.WriteLine("Method3 started using " + Thread.CurrentThread.Name);
            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine("Method3 : " + i);
            }
            Console.WriteLine("Method3 ended using " + Thread.CurrentThread.Name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Thread t1 = new Thread(method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(method2)
            {
                Name = "Thread2"

            };
            Thread t3 = new Thread(method3)
            {
                Name = "Thread3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            
            Console.WriteLine("Main Thread Ended");
        }
    }
}
