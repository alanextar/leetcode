using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LinkedList
{
    public class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var memorize = false;
            var node = new ListNode();
            var head = node;

            while (l1 != null || l2 != null)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + (memorize ? 1 : 0);
                node.val = sum % 10;

                memorize = sum >= 10;
                if (memorize || l1?.next != null || l2?.next != null)
                {
                    node.next = new ListNode();
                    node = node.next;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (memorize)
            {
                node.val = 1;
            }

            return head;
        }
    }
}
