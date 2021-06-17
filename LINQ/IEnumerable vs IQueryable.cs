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

            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            var IEnumerable_QuerySyntax = from num in integerList
                                           where num > 5
                                           select num;
            var IEnumerable_MethodSyntax = integerList.Where(num => num > 5); // If we apply .ToList() it will be converted to List type



            var IQueryable_QuerySyntax = (from num in integerList
                                          where num > 5
                                          select num).AsQueryable();  // Converting IEnumerable to IQueryable

            var IQueryable_MethodSyntax = integerList.AsQueryable().Where(num => num > 5);


            // IEnumerable fetches all data from db to memory and applies filter in client side. Filtering occurs in client side

            // IQueryable fetches required data from db after fitlering. Filtering occurs in db

        }
    }
}
