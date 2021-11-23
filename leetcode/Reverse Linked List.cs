using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class Reverse_Linked_List
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            var stack = new Stack<ListNode>();
            var current = head;

            while (current.next != null)
            {
                stack.Push(current);
                current = current.next;
            }

            head = current;
            while (stack.Count > 0)
            {
                current.next = stack.Peek();
                stack.Pop();
                current = current.next;
            }
            current.next = null;

            return head;
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
}
