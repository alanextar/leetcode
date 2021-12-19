using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LinkedList
{
    public class Convert_Binary_Number_in_a_Linked_List_to_Integer
    {
        public int GetDecimalValue(ListNode head)
        {
            var binaryStr = "";

            while (head != null)
            {
                binaryStr += head.val;
                head = head.next;
            }

            return Convert.ToInt32(binaryStr, 2);
        }

        public int GetDecimalValue1(ListNode head)
        {
            var runner = head;
            int res = 0;
            while (runner != null)
            {
                res = (res * 2 + runner.val);
                runner = runner.next;
            }
            return res;
        }

        public static int GetDecimalValue(int[] arr)
        {
            double num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                num += arr[i] * Math.Pow(2, i);
            }

            return (int)num;
        }
    }
}
