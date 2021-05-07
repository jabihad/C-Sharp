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
            List<string> names = new List<string>() { "Jim", "John", "Jane", "Fizz", "Tom" };

            var ls = ContainsLetter(names, name => name.Contains("o"));

            foreach (var name in ls)
            {
                Console.WriteLine(name);  // John, Tom
            }
        }
        public static IEnumerable<string> ContainsLetter(List<string> names, Func<string, bool> nameComparer)
        {
            List<string> ls = new List<string>();
            foreach (var name in names)
            {
                if (nameComparer(name))
                    ls.Add(name);
            }
            return ls;
        }
    }
}
