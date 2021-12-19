using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class MyQueue
    {
        public Stack<int> stack1 = new Stack<int>();
        public Stack<int> stack2 = new Stack<int>();


        public MyQueue()
        {

        }

        public void Push(int x)
        {
            stack1.Push(x);
            if (stack2.Count() > 0)
            {
                stack1.Push(stack2.Pop());
            }

            stack2.Push(x);
        }

        public int Pop()
        {
            return stack2.Pop();
        }

        public int Peek()
        {
            return stack2.Peek();
        }

        public bool Empty()
        {
            return stack2.Count() == 0 && stack1.Count() == 0;
        }
    }

}
