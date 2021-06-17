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

/// What is Extension Method
            // 1. Extension methods allow us to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. 

            // 2. extend the functionality of a class by adding new methods in the future if the source code of the class is not available
            //    or if we don’t have any permission in making changes to the class.

            // 3. Extension methods are the special kind of static methods of a static class, but they are going to be called as if they were instance methods on the extended type.

            // 4. Such as - Where method. Where is not a memeber of List<T> class. But we can call Where on List() as if Where is part of List<T> class

            // 5. The LINQ’s standard query operators such as select, where, etc. are implemented in Enumerable class.
            // 6. These methods are implemented as extension methods of the type IEnumerable<T> interface and List is child of IEnumerable

/// Following points need to be considered when creating an extension method:
            // 1.The class which defines an extension method must be non-generic, static and non-nested
            // 2. Every extension method must be a static method  
            // 3. The first parameter of the extension method should use the this keyword.
