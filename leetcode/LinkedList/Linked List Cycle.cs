using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LinkedList
{
    public class Linked_List_Cycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            var visitedNodes = new HashSet<ListNode>();
            while (head.next != null)
            {
                if (visitedNodes.Contains(head))
                {
                    return true;
                }
                visitedNodes.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
