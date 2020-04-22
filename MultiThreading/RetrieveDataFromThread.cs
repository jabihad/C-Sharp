using System.Threading;
using System;
namespace Test
{
    // CallBack delegate and CallBack method signature must be same
    public delegate void ResultCallBackDelegate(int Result);
    class NumberHelper
    {
        private int _number;
        private ResultCallBackDelegate _resultCallBackDelegate;
        public NumberHelper(int number, ResultCallBackDelegate resultCallBackDelegate)
        {
            _number = number;
            _resultCallBackDelegate = resultCallBackDelegate;
        }
        public void CalculateSum()
        {
            int sum = 0;
            for(int i=1; i<=_number; i++)
               sum += i;
            //Before the end of the thread function call the callback method
            if (_resultCallBackDelegate != null)
            {
                _resultCallBackDelegate(sum);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ResultCallBackDelegate resultCallBackDelegate = new ResultCallBackDelegate(ResultCallBackMethod);
            int Number = 10;
            NumberHelper obj = new NumberHelper(Number, resultCallBackDelegate);
            Thread t1 = new Thread(new ThreadStart(obj.CalculateSum));

            t1.Start();
        }
        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("Result is " + Result);
        }
    }

}
