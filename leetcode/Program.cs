using leetcode.Array;
using leetcode.BinaryTree;
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
			var reverseLinkedList = new Reverse_Linked_List();
			var thirdNode = new ListNode() { val = 3 };
			var secondNode = new ListNode() { val = 2, next = thirdNode };
			var head = new ListNode() { val = 1, next = secondNode };
			reverseLinkedList.ReverseList(head);

			Console.WriteLine("Hello World!");
		}
	}
	
}
