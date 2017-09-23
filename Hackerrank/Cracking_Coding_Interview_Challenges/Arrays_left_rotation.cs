using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Arrays: Left Rotation
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation
    /// </summary>
    public class Arrays_left_rotation : IExecute
    {
        public void Execute()
        {
            // Read input values.
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int count = numbers[0];
            int rotations = numbers[1];
            // Read array.
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            // Rotate.
            Rotate(arr, rotations);
            //
            Console.WriteLine(String.Join(" ", arr));
        }

        /// <summary>
        /// Rotate array by number of times.
        /// </summary>
        /// <param name="arr">Array to rotate.</param>
        /// <param name="rotations">Number of rotations.</param>
        private void Rotate(int[] arr, int rotations)
        {
            if (arr == null || rotations < 1 || arr.Length < 2)
            {
                return;
            }
            else if (rotations > arr.Length)
            {
                rotations = arr.Length % rotations;
            }

            ReverseArray(arr, 0, rotations - 1);
            ReverseArray(arr, rotations, arr.Length - 1);
            ReverseArray(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Reverse an array.
        /// </summary>
        /// <param name="arr">Array to reverse.</param>
        /// <param name="start">Start index.</param>
        /// <param name="end">End index.</param>
        private void ReverseArray(int[] arr, int start, int end)
        {
            if (arr == null || arr.Length < 2 || start < 0 || end < 0 || start > end)
            {
                return;
            }

            int startValue = 0;
            while (start<end)
            {
                startValue = arr[start];
                arr[start] = arr[end];
                arr[end] = startValue;
                start++;
                end--;
            }
        }
    }
}
