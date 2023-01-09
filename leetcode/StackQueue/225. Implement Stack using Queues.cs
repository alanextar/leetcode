using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.StackQueue
{
    public static class Program225
    {
        public static void Main_225(string[] args)
        {
            var s = new MyStack();
            s.Push(1);
            s.Push(2);
            s.Top();
            s.Pop();
            s.Empty();

            Console.WriteLine("Hello World!");
        }
    }

    public class MyStack 
    {
        private Queue<int> q1 { get; set; } = new Queue<int>();
        private Queue<int> q2 { get; set; } = new Queue<int>();

        public MyStack() {
        
        }
    
        public void Push(int x) {
            if (q1.Count > 0)
            {
                while (q1.TryDequeue(out var deq1))
                {
                    q2.Enqueue(deq1);
                }
            }

            q1.Enqueue(x);
            while (q2.TryDequeue(out var deq2))
            {
                q1.Enqueue(deq2);
            }
        }
    
        public int Pop() {
            return q1.Dequeue();
        }
    
        public int Top() {
            return q1.Peek();
        }
    
        public bool Empty() {
            return q1.Count == 0;
        }
    }
}
