using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Dynamic_Programming
{
    /// <summary>
    /// Fibonacci Modified.
    /// https://www.hackerrank.com/challenges/fibonacci-modified
    /// </summary>
    public class Fibonacci_Modified : IExecute
    {
        public void Execute()
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int t1 = a[0];
            int t2 = a[1];
            int n = a[2];

            Console.WriteLine(string.Format("{ 0:n0}",GetFibonacciValue(t1, t2, n)));
        }

        private double GetFibonacciValue(int t1, int t2, int n)
        {
            if (n == 2)
            {
                return t2;
            }
            else if (n == 3)
            {
                return (Math.Pow(t2, 2)) + t1;
            }
            else if (n > 3)
            {
                return (Math.Pow(GetFibonacciValue(t1, t2, n-1), 2)) + GetFibonacciValue(t1, t2, n - 2);
            }

            return 0;
        }
    }
}
