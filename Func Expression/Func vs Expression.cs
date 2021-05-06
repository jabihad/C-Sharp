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
            Func<int, int> F = ExpressionAsMethod.Compile();
            IEnumerable<int> d = new List<int>() { 1, 2, 3, 4, 5 };
            var itemAsQueryable = d.AsQueryable();
            foreach (var item in itemAsQueryable)
            {
                Console.WriteLine(F(item));        // 1, 4, 9, 16, 25
            }

            // 


        }
    }
}
