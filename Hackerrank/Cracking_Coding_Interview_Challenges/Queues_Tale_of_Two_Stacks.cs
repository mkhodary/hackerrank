using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    public class Queues_Tale_of_Two_Stacks : IExecute
    {
        public void Execute()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> q = new Queue<int>();

            string[] commands = new string[n];

            for (int i = 0; i < n; i++)
            {
                commands[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                int[] c = Array.ConvertAll(commands[i].Split(' '), int.Parse);
                if (c[0] == 1)
                {
                    q.Enqueue(c[1]);
                }
                else if (c[0] == 2)
                {
                    q.Dequeue();
                }
                else if (c[0] == 3)
                {
                    Console.WriteLine(q.Peek());
                }
            }
        }
    }
}
