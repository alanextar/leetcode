using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String
{
    public class Reverse_String
    {
        public void ReverseString(char[] s)
        {
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                s.SwapValues(i, j);
                i++;
                j--;
            }
        }
    }
}
