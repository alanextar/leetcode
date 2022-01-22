using leetcode.Array;
using leetcode.BinaryTree;
using leetcode.Bitmask;
using leetcode.LinkedList;
using leetcode.StackQueue;
using leetcode.String;
using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	public static class CombinationIteratorProgram
	{
		public static void CombinationIteratorProgramMain(string[] args)
		{
			var combIter = new CombinationIterator("bvwz", 2);
			combIter = new CombinationIterator("ab", 2);
			combIter.Next();
			combIter.HasNext();
			combIter.Next();
			combIter.Next();
			combIter.Next();

			Console.WriteLine("Hello World!");
		}
	}
	
}
