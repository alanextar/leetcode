using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LinkedList
{
    public class _328
    {
        public ListNode OddEvenList(ListNode head) {
            if (head?.next == null)
            {
                return head;
            }

            var oddNode = head;
            var evenNode = head.next;
            var evenHead = head.next;

            while (oddNode.next?.next != null)
            {
                oddNode.next = oddNode?.next?.next;
                oddNode = oddNode?.next;
                evenNode.next = evenNode?.next?.next;
                evenNode = evenNode?.next;
            }

            oddNode.next = evenHead;

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

    public static class Program328
    {
        public static void Main_328(string[] args)
        {
            var s = new _328();

            var head = new ListNode(1)
            {
                next = new ListNode(2){
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                    }
                }
            };

            var res = s.OddEvenList(head);
        }
    }
}
