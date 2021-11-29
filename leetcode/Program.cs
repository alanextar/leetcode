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
			var l1 = new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3 } } };
			var l2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4 } } };
			var addTwoNumbers = new Add_Two_Numbers().AddTwoNumbers(l1, l2);

			var l11 = new ListNode();
			var l22 = new ListNode();
			var addTwoNumbers2 = new Add_Two_Numbers().AddTwoNumbers(l11, l22);

			var l111 = new ListNode { val = 9, 
				next = new ListNode { val = 9, 
					next = new ListNode { val = 9, 
						next = new ListNode { val = 9, 
							next = new ListNode { val = 9, 
								next = new ListNode { val = 9, 
									next = new ListNode { val = 9 } 
								} 
							} 
						} 
					} 
				} 
			};

			var l222 = new ListNode { val = 9, 
				next = new ListNode { val = 9, 
					next = new ListNode { val = 9, 
						next = new ListNode { val = 9, 
						} 
					} 
				} 
			};

			var addTwoNumbers3 = new Add_Two_Numbers().AddTwoNumbers(l111, l222);

			Console.WriteLine("Hello World!");
		}
	}
	
}
