using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Time Complexity: Primality.
    /// https://www.hackerrank.com/challenges/ctci-big-o/problem
    /// </summary>
    public class Time_Complexity_Primality : IExecute
    {
        public void Execute()
        {
            int p = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < p; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (IsPrime(n))
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not prime");
            }
        }

        public bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(n);

            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
