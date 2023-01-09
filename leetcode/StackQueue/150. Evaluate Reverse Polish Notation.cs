using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.StackQueue
{
    public static class Program150
    {
        public static void Main150(string[] args)
        {
            var s = new _150();
            var tokens = new string[] { "10","6","9","3","+","-11","*","/","*","17","+","5","+" };
            var res = s.EvalRPN(tokens);

            Console.WriteLine("Hello World!");
        }
    }

    internal class _150
    {
        public int EvalRPN(string[] tokens) {
            var stack = new Stack<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if (int.TryParse(tokens[i], out var num))
                {
                    stack.Push(num);
                    continue;
                }

                var num2 = stack.Pop();
                var num1 = stack.Pop();
                int res = 0;
                switch (tokens[i])
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                    default:
                        break;
                }

                stack.Push(res);
            }

            return stack.Pop();
        }
    }
}
