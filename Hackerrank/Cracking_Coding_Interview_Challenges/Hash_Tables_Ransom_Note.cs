using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Hash Tables: Ransom Note.
    /// https://www.hackerrank.com/challenges/ctci-ransom-note
    /// </summary>
    public class Hash_Tables_Ransom_Note : IExecute
    {
        public void Execute()
        {
            int[] counts = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string m = Console.ReadLine();
            string n = Console.ReadLine();

            Dictionary<string, int> magazineDic = BuildDictionary(m);
            Dictionary<string, int> ransomDic = BuildDictionary(n);

            bool hasRandom = true;
            foreach (var item in ransomDic)
            {
                if (!magazineDic.ContainsKey(item.Key) || magazineDic[item.Key] < item.Value)
                {
                    hasRandom = false;
                    break;
                }
            }

            if (hasRandom)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        Dictionary<string, int> BuildDictionary(string str)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (dic.ContainsKey(words[i]))
                {
                    dic[words[i]]++;
                }
                else
                {
                    dic.Add(words[i], 1);
                }
            }

            return dic;
        }
    }
}
