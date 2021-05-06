using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, bool> FuncAsParameter = a => a > 3;
            IEnumerable<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            var itemFunc = a.Where(FuncAsParameter);
            foreach (var item in itemFunc)
            {
                Console.WriteLine(item);           // 4, 5
            }

            Func<int, int> FuncAsMethod = a => a * a;
            IEnumerable<int> b = new List<int>() { 6, 7, 8, 9, 10 };
            foreach (var item in b)
            {
                Console.WriteLine(FuncAsMethod(item));
            }

            Expression<Func<int, bool>> ExpressionAsParameter = a => a > 22;
            IEnumerable<int> c = new List<int>() { 11, 22, 33, 44, 55, 66 };
            var itemExpression = c.AsQueryable().Where(ExpressionAsParameter);
            foreach (var item in itemExpression)
            {
                Console.WriteLine(item);           // 33, 44, 55, 66
            }

            Expression<Func<int, int>> ExpressionAsMethod = a => a * a;
            Func<int, int> F = ExpressionAsMethod.Compile();  // Convert Expression to Func
            IEnumerable<int> d = new List<int>() { 1, 2, 3, 4, 5 };
            var itemAsQueryable = d.AsQueryable();
            foreach (var item in itemAsQueryable)
            {
                Console.WriteLine(F(item));        // 1, 4, 9, 16, 25
            }

            // IEnumerable<T> extensions accept Func<TSource, bool>. We don’t need an expression for IEnumerable as it’s just an in-memory collection
            // IQueryable<T> extensions accept Expression<Func<TSource, bool>>

            // We can call them with the exact same syntax 
            //                                          Func - .Where(x => x.property == "value")
            //                                    Expression - .Where(x => x.property == "value")


            // Expression<Func<T>> is a description of a function as an expression tree. 
            // It can be compiled to IL at run time that generates a Func<T> 
            // but it can also be translated to other languages e.g.SQL in LINQ to SQL.
            // We  need an expression for IQueryable because we don’t know what we’re querying 
            // the specific IQueryable implementation will translate the given expression into 
            // whatever language needed to access the data.E.g.SQL in LINQ to SQL, or a specific HTTP request for a REST API.

            // Summary
            // Func<T, bool> is a pointer to a compiled delegate method 
            // Expression<Func<T, bool>> is a description of a function 
            // that can be compiled to IL at runtime or translated into whatever language we have a provider for.

        }
    }
}
