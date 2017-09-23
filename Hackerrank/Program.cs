using Hackerrank.Common;
using Hackerrank.Cracking_Coding_Interview_Challenges;
using Hackerrank.Dynamic_Programming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //IExecute r = new Fibonacci_Modified();
            //r.Execute();
            int[] nums = new int[5] { 5, 4, 3, 5, 11 };
            int[] maxes = new int[2] { 10, 4 };
            int[] result = counts(nums, maxes);

            Console.ReadLine();
            
        }

        static int[] counts(int[] nums, int[] maxes)
        {
            // sort the unsorted array.
            sortNums(nums, 0, nums.Length - 1);

            //
            int[] result = new int[maxes.Length];
            for (int x = 0; x < maxes.Length; x++)
            {
                int valueToCompare = maxes[x];
                int count = getCountOfIntsBelow(nums, valueToCompare);
                result[x] = count;
            }

            return result;
        }

        static int getCountOfIntsBelow(int[] nums, int v)
        {
            int count = 0;
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] <= v)
                    count ++;
                else
                    break;
            }
            return count;
        }

        static void sortNums(int[] nums, int left, int right)   
        {
            int i = left;
            int j = right;

            int pivot = nums[(left + right) / 2];

            while (i <= j)
            {
                while (nums[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (nums[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // swap elements.
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                sortNums(nums, left, j);
            }
            if (i < right)
            {
                sortNums(nums, i, right);
            }
        }

        static int[] getMinimumDifference(string[] a, string[] b)
        {
            int n = a.Length;
            int[] result = new int[n];

            for (int x = 0; x < n; x++)
            {
                string v1 = a[x];
                string v2 = b[x];

                List<char> bList = new List<char>();
                bList = v2.ToList();

                if (v1.Length != v2.Length)
                {
                    result[x] = -1;
                    continue;
                }
                else
                {
                    for (int i = 0; i < v1.Length; i++)
                    {
                        if (bList.Contains(v1[i]))
                        {
                            bList.Remove(v1[i]);
                        }
                    }
                }

                result[x] = bList.Count();
            }

            return result;
        }
    }
}
