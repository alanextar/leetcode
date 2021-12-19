using leetcode.Array;
using leetcode.BinaryTree;
using leetcode.LinkedList;
using leetcode.StackQueue;
using leetcode.String;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			var minStack = new MinStack();
			minStack.Push(0);
			minStack.Push(1);
			minStack.Push(0);
            Console.WriteLine(minStack.GetMin());
			minStack.Pop();
            //Console.WriteLine(minStack.Top());
            Console.WriteLine(minStack.GetMin());
			

			Console.WriteLine("Hello World!");
		}
	}
	
}
