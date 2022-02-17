using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public static class Program232
    {
        public static void Main232(string[] args)
        {
            var q = new MyQueue();
            q.Push(1);
            q.Push(2);
            q.Peek();
            q.Pop();
            q.Empty();

            Console.WriteLine("Hello World!");
        }
    }

    public class MyQueue
    {
        private Stack<int> stack1;
        private Stack<int> stack2;


        public MyQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void Push(int x)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            stack2.Push(x);
            while (stack2.Count > 0)
                stack1.Push(stack2.Pop());
        }

        public int Pop()
        {
            return stack1.Pop();
        }

        public int Peek()
        {
            return stack1.Peek();
        }

        public bool Empty()
        {
            return stack1.Count() == 0;
        }
    }

}
