using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.StackQueue
{
    public class MinStack
    {
        private Stack<int> Stack { get; set; } = new();
        private Stack<int> Min { get; set; } = new();

        public MinStack()
        {

        }

        public void Push(int val)
        {
            Stack.Push(val);
            if (Min.Count == 0)
            {
                Min.Push(val);
            }
            else if(Min.TryPeek(out var result) && result >= val)
            {
                Min.Push(val);
            }
        }

        public void Pop()
        {
            var stVal = Stack.Pop();
            Min.TryPeek(out var minVal);
            if (stVal == minVal)
            {
                Min.Pop();
            }
        }

        public int Top()
        {
            return Stack.Peek();
        }

        public int GetMin()
        {
            return Min.Peek();
        }
    }
}
