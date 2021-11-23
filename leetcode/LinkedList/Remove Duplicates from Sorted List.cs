using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LinkedList
{
    public class Remove_Duplicates_from_Sorted_List
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            ListNode prev = head;
            ListNode cur = head;
            var nodes = new HashSet<int>();
            while (cur != null)
            {
                if (!nodes.Contains(cur.val))
                {
                    nodes.Add(cur.val);
                    prev = cur;
                }
                else
                {
                    prev.next = cur.next;
                }

                cur = cur.next;
            }

            return head;
        }
    }
}
