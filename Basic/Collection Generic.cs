using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Array
            int[] a = new int[45];       // Size must have to be provided

            int[] b = { 1, 2, 3, 4, 5 }; // Without Size

            // Class
            Student obj1 = new Student();

            Student obj2 = new Student()
            {
                Id = "12",
                Name = "jihad"
            };

      ///// C O  L L E C T I O N  //////
            // Same Sollection can contain different type of data
            // Memory increases dynamically

            ArrayList al = new ArrayList(); // al.Add(1); al.Add("qwe");

            Hashtable Ht = new Hashtable(); // Ht.Add(1, "jihad");Ht.Add("kamal", 2);
            
            // foreach(DictionaryEntry k in d) k.Key, k.Value

            // foreach(var item in Ht)
            // {
            //    Console.WriteLine(item.Key);
            //    This won't work for all type of key value pair type collection such as SortedList. But works for generic
            // }

            Stack s = new Stack(); //s.Push(1); s.Push("jihad"); s.Pop();

            Queue q = new Queue(); // q.Enqueue("Jihad"); q.Enqueue(1); q.Dequeue();

            SortedList sl = new SortedList();   // sl.Add(1, "Jihad"); sl.Add("Kamal", 2);
            // If keys are different type the following won't work because it sorts according to key. But works in Hashtable
            //foreach(var k in sl.Keys)
            //{
            //    Console.WriteLine(sl[k]);
            //}


       //////  G  E  N  R  I  C /////

            List<int> l = new List<int>();

            HashSet<int> Hs = new HashSet<int>(); // Same as List but doesn't save duplicate value, faster than List

            Dictionary<int, string> d = new Dictionary<int, string>(); // foreach(KeyValuePair<int, string> k in d) k.Key k.Value

            Stack<int> S = new Stack<int>();

            Queue<int> Q = new Queue<int>();

            SortedList<int, string> SL = new SortedList<int, string>(); // Sort List accoding to key
            //foreach (var kvp in SL)
            //{
            //    Console.WriteLine(kvp.Key);
            //}


            // Remarks
            // It is recommended to use Generic Stack<T>, Queue<T>, SortedList<TKey, TValue>
            // rather than Collection Stack, Queue, SortedList
            // because they perform faster and less error-prone than the collection / non-generic

        }
    }
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
