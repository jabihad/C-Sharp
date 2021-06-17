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
            List<int> intList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

      /////    LINQ Query using Query Syntax
            var QuerySyntax = from num in intList // Initialization
                              where num > 5       // Condition
                              select num;         // Selection    // Query is not executed here

            //Deferred Execution
            foreach (var item in QuerySyntax)                     // Query is executed here    
            {
                Console.Write(item + " "); // 6, 7, 8, 9, 10
            }
            intList.Add(11);
            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " "); // 6, 7, 8, 9, 10, 11       
                                           // New element 11 is shown here. It means query is executed when its value is required
            }


      /////    LINQ Query using Method Syntax
            var methodSyntax = intList.Where(num => num > 5).ToList(); // Query is execeuted when we use ToList()
            Console.WriteLine(methodSyntax[0]); // 6
             

      /////    LINQ Query using Mixed Syntax
            var mixedSyntax = (from obj in intList
                               where obj > 5
                               select obj).Sum();   // Query Syntax + Method Syntax. Sum() is method syntax

            Console.WriteLine(mixedSyntax);  // 51


        }
    }
}
