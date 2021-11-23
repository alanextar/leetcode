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

            while (current != null)
            {
                stack.Push(current);
                current = current.next;
            }

            ListNode nextNode = new ListNode();
            head = nextNode;
            while (stack.Count > 0)
            {
                nextNode.val = stack.Pop().val;
                if (stack.Count > 0)
                {
                    nextNode.next = new ListNode();
                    nextNode = nextNode.next;
                }
            }

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
