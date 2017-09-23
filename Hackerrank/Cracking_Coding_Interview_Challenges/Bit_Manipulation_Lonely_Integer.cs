using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Bit Manipulation: Lonely Integer
    /// https://www.hackerrank.com/challenges/ctci-lonely-integer
    /// </summary>
    public class Bit_Manipulation_Lonely_Integer : IExecute
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            Console.WriteLine(lonelyInteger(a));
        }

        public int lonelyInteger(int[] a)
        {
            int value = 0;

            for (int i = 0; i < a.Length; i++)
            {
                value ^= a[i];
            }

            return value;
        }
    }
}
