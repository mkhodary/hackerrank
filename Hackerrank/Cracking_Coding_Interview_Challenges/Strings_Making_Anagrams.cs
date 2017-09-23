using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Strings: Making Anagrams.
    /// https://www.hackerrank.com/challenges/ctci-making-anagrams
    /// </summary>
    public class Strings_Making_Anagrams : IExecute
    {
        public void Execute()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int result = 0;
            
            result = GetCharactersCountToRemoveToGetAnagrams(str1.ToCharArray(0, str1.Length), str2.ToCharArray(0, str2.Length));

            Console.WriteLine(result);
        }

        /// <summary>
        /// Get characters count to remove to reach anagrams.
        /// </summary>
        /// <param name="arr1">Array 1.</param>
        /// <param name="arr2">Array 2.</param>
        /// <returns></returns>
        private int GetCharactersCountToRemoveToGetAnagrams(Char[] arr1, Char[] arr2)
        {
            Dictionary<char, int> dictionary1 = new Dictionary<char, int>();
            FillDictionary(dictionary1, arr1);

            Dictionary<char, int> dictionary2 = new Dictionary<char, int>();
            FillDictionary(dictionary2, arr2);

            // Compare dictionaries
            int result = 0;
            foreach (var item in dictionary1)
            {
                if (dictionary2.ContainsKey(item.Key))
                {
                    result += Math.Abs(dictionary2[item.Key] - item.Value);
                    dictionary2.Remove(item.Key);
                }
                else
                {
                    result += item.Value;
                }
            }
            foreach (var item in dictionary2)
            {
                result += item.Value;
            }

            return result;
        }

        /// <summary>
        /// Fill dictionary by array items and add number of repeated characters.
        /// </summary>
        /// <param name="dic">Dictionary.</param>
        /// <param name="arr">Array of characters.</param>
        private void FillDictionary(Dictionary<char, int> dic, char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic.Add(arr[i], 1);
                }
            }
        }
    }
}
