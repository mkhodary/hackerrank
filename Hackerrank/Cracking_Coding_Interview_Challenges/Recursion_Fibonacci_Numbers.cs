using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Recursion: Fibonacci Numbers
    /// https://www.hackerrank.com/challenges/ctci-fibonacci-numbers
    /// </summary>
    public class Recursion_Fibonacci_Numbers : IExecute
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }

        public int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
