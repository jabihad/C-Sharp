using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<string> names = new List<string>() { "Jim", "John", "Jane", "Fizz", "Tom" };

            names = names.AsQueryable();
            var ls = ContainsLetter(names, name => name.Contains("o"));

            foreach (var name in ls)
            {
                Console.WriteLine(name);  // John, Tom
            }
        }
        public static IEnumerable<string> ContainsLetter(IEnumerable<string> names, Expression<Func<string, bool>> nameComparer)
        {
            var name = names.AsQueryable().Where(nameComparer);
            return name;
        }
    }
}
