using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Tries: Contacts
    /// https://www.hackerrank.com/challenges/ctci-contacts
    /// </summary>
    public class Tries_Contacts : IExecute
    {
        public void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }

            //
            Trie trie = new Trie();
            for (int i = 0; i < n; i++)
            {
                string[] command = input[i].Split(' ');
                if (command[0] == "add")
                {
                    trie.Add(command[1]);
                }
                else if (command[0] == "find")
                {
                    int count = trie.Find(command[1]);
                    Console.WriteLine(count);
                }
            }
        }
    }

    public class Trie
    {
        private Node _parentNode = new Node(null);

        public Trie()
        {
            
        }

        public void Add(String input)
        {
            if (string.IsNullOrEmpty(input))
                return;

            Node node = _parentNode;

            for (int i = 0; i < input.Length; i++)
            {
                if (node.Childs.ContainsKey(input[i]))
                {
                    node = node.Childs[input[i]];
                }
                else
                {
                    Node childNode = node.AddChild(input[i]);
                    if (i == input.Length - 1)
                    {
                        childNode.IsLeaf = true;
                    }
                    node = childNode;
                }
                node.LeavesCount++;
            }
        }

        public int Find(string input)
        {
            // get last node that hs the last index of string if existing.
            if (string.IsNullOrEmpty(input))
                return 0;

            Node node = _parentNode;

            for (int i = 0; i < input.Length; i++)
            {
                if (node.Childs.ContainsKey(input[i]))
                {
                    node = node.Childs[input[i]];
                }
                else
                {
                    return 0;
                }
            }

            // count leaf childs of selected node
            return node.GetLeavesCount();
        }
    }

    public class Node
    {
        public Dictionary<char, Node> Childs { get; set; }
        public bool IsLeaf { get; set; }
        public char? Value { get; private set; }
        public int LeavesCount { get; set; }

        public Node(char? v)
        {
            Childs = new Dictionary<char, Node>();
            IsLeaf = false;
            Value = v;
            LeavesCount = 0;
        }

        public Node AddChild(char c)
        {
            Node childNode;
            if (Childs.ContainsKey(c))
            {
                childNode = Childs[c];
            }
            else
            {
                childNode = new Node(c);
                Childs.Add(c, childNode);
            }
            return childNode;
        }

        public int GetLeavesCount()
        {
            return LeavesCount;

            //// bad performance if commented code used!

            //int count = 0;

            //if (IsLeaf == true)
            //    count++;

            //foreach (var item in Childs)
            //{
            //    count += item.Value.GetLeavesCount();
            //}

            //return count;
        }
    }
}
