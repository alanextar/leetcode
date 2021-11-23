using leetcode.Array;
using leetcode.BinaryTree;
using leetcode.LinkedList;
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
			var reverseLinkedList = new Remove_Duplicates_from_Sorted_List();
			var thirdNode = new ListNode() { val = 3 };
			var secondNode = new ListNode() { val = 1 };
			var first = new ListNode() { val = 1 };
			first.next = secondNode;
			secondNode.next = thirdNode;

			reverseLinkedList.DeleteDuplicates(first);

			Console.WriteLine("Hello World!");
		}
	}
	
}
