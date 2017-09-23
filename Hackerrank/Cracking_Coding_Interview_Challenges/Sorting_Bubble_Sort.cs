using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    public class Sorting_Bubble_Sort : IExecute
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int numberOfSwaps = BubbleSort(n, a);

            Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Length - 1]);
        }

        private int BubbleSort(int n, int[] a)
        {
            int totalNumberofSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        swap(j, j + 1, a);
                        numberOfSwaps++;
                        totalNumberofSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            return totalNumberofSwaps;
        }

        private void swap(int v1, int v2, int[] a)
        {
            int temp = a[v2];
            a[v2] = a[v1];
            a[v1] = temp;
        }
    }
}
