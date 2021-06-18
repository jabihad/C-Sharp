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
            var querySyntax1 = (from num in ara
                               where num > 0
                               select num).Reverse();
            var methodSyntax1 = ara.Reverse();

            List<string> stringList = new List<string>() { "Rafiq", "Kamal", "Shafiq", "Rakib", "Hasan" };

            // var methodSyntax2 = stringList.Reverse(); // This is not valid. Because its return type is void
            // only stringList.Reverse() is permissible. Can't assign it to var
            var querySyntax2 = (from name in stringList
                               where name != null
                               select name).Reverse();

            var methodSyntax2 = stringList.AsQueryable().Reverse();

            foreach(var num in querySyntax2)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
