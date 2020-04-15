using System;
using System.IO;
namespace InnerException
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number:");
                    int FirstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:");
                    int SecondNumber = Convert.ToInt32(Console.ReadLine());
                    
                    int result = FirstNumber / SecondNumber;
                    Console.WriteLine("Result = {0}", result);
                }
                catch(Exception ex)
                {
                    string FilePath = @"F:\C#\est\Test\Log.txt";
                    if(File.Exists(FilePath))
                    {
                        StreamWriter sw = new StreamWriter(FilePath);
                        sw.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem.Please check the log file");
                    }
                    else
                    {
                        throw new FileNotFoundException(FilePath + "doesn't exist", ex);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Current or Outer Exception = " + e.Message);
                if(e.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: ");
                    Console.WriteLine(String.Concat(e.InnerException.StackTrace, e.InnerException.Message));
                }
            }
        }
    }
}
