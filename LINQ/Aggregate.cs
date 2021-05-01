using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] ara = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int mn, mx, count, sum, evenMin;
            double avg;

            mn = ara.Min();  // returns 1

            evenMin = ara.Where(x => x % 2 == 0).Min(); // returns 2

            mx = ara.Max(); // returns 10

            count = ara.Count(); // returns 10

            avg = ara.Average(); // returns 5.5

            sum = ara.Sum(); // returns 55


            string[] s = { "a", "ab", "abc" };
            int mnStringLength = s.Min(x => x.Length); // returns 1


            string[] countries = { "US", "UK", "Bangladesh", "UAE", "India" };
            string res = countries.Aggregate((a, b) => (a + ", " + b)); // returns "US", "Uk", "Bangladesh", "UAE", "India"
            //      1st Execution   a = "US", b = "UK" res = "US, UK"
            //      2nd Execution   a = "US, UK", b = "Bangladesh" res = "US, UK, Bangladesh"
            //      .....

            int[] numbers = { 1, 2, 3, 4, 5 };
            int fact = numbers.Aggregate((a, b) => a * b); // returns 120
                                                  // 1*2 = 2
                                                  // 2*3 = 6
                                                  // 6*4 = 24
                                                  // 24*5 = 120

        }
    }
}
