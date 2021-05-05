using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ls.ShowFirstNElement(3);
        }

    }
    public static class Extension
    {
        public static void ShowFirstNElement(this List<int> ls, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ls[i]);
            }
        }
    }
}
//                Following points need to be considered when creating an extension method:

//                1.The class which defines an extension method must be non-generic, static and non-nested

//                2. Every extension method must be a static method

//                3. The first parameter of the extension method should use the this keyword.
