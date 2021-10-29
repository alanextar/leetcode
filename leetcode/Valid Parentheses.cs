using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class Valid_Parentheses
    {
        public static string validCase1 = "()[]{}";
        public static string validCase2 = "([]){}";
        public static string inValidCase1 = "([)]{}";
        public static string inValidCase2 = "([";
        public static string inValidCase3 = "(";
        public static string inValidCase4 = "";

        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }

            var parenthesisMatchDic = new Dictionary<char, char>() { 
                { '}', '{' }, 
                { ']', '[' },
                { ')', '(' } 
            };
            var stack = new Stack<char>();

            foreach (var item in s)
            {
                if (parenthesisMatchDic.ContainsKey(item))
                {
                    if (stack.Count == 0 || stack.Pop() != parenthesisMatchDic[item])
                    {
                        return false;
                    }
                }
                else
                    stack.Push(item);
            }

            return stack.Count == 0;
        }
    }
}
