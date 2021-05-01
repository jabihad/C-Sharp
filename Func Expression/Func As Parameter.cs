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
            List<string> names = new List<string>(){"Jim", "John", "Jane", "Fizz", "Tom"};

            foreach (var name in ContainsLetter(names, name => name.Contains("o")))
            {
                Console.WriteLine(name);
            }
        }
        public static IEnumerable<string> ContainsLetter(List<string> names, Func<string, bool> nameComparer)
        {
            foreach(var name in names)
            {
                if(nameComparer(name))
                    yield return name;
            }
        }
    }
}
