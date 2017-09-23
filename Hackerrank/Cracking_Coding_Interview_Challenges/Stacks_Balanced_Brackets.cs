using Hackerrank.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Cracking_Coding_Interview_Challenges
{
    /// <summary>
    /// Stacks: Balanced Brackets
    /// https://www.hackerrank.com/challenges/ctci-balanced-brackets
    /// </summary>
    public class Stacks_Balanced_Brackets : IExecute
    {
        public void Execute()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] text = new string[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                text[a0] = expression;
            }

            for (int i = 0; i < t; i++)
            {
                string expression = text[i];
                if (IsBalancedBrackets(expression))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        private bool IsBalancedBrackets(string expresssion)
        {
            Char[] characters = expresssion.ToCharArray();
            if (characters.Length % 2 != 0)
                return false;

            Stack<Char> stack = new Stack<char>();

            for (int i = 0; i < characters.Length; i++)
            {
                if (IsBegin(characters[i]))
                {
                    stack.Push(characters[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char beginingBracket = stack.Pop();
                    char closingBracket = characters[i];

                    if (!IsValidClosingBracket(beginingBracket, closingBracket))
                        return false;
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }

            return true;
        }

        private bool IsValidClosingBracket(char begin, char close)
        {
            if (begin == '{' && close == '}') return true;
            if (begin == '[' && close == ']') return true;
            if (begin == '(' && close == ')') return true;
            return false;
        }

        private bool IsBegin(char c)
        {
            if (c == '{' || c== '[' || c== '(')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
