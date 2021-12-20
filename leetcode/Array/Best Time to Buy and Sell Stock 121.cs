using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    public class Best_Time_to_Buy_and_Sell_Stock_121
    {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            var min = 0;
            var max = 0;

            if (prices == null || prices.Length <= 1)
            {
                return maxProfit;
            }

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > prices[max] || i > min)
                {
                    max = i;
                }
                if (prices[i] < prices[min])
                {
                    min = i;
                }

                if (max > min)
                {
                    maxProfit = Math.Max(maxProfit, prices[max] - prices[min]);
                }
            }

            return maxProfit < 0 ? 0 : maxProfit;
        }
    }
}


//var left = 0;
//var right = 0;
//while (left <= right) 
//{
//    int currentMinIndex;
//    int currentMaxIndex;

//    if (prices[left] < prices[right])
//    {
//        currentMinIndex = left;
//        currentMaxIndex = right;
//    }
//    else
//    {
//        currentMinIndex = right;
//        currentMaxIndex = left;
//    }

//    minIndex = Math.Min(minIndex, currentMinIndex);
//    maxIndex = Math.Max(maxIndex, currentMaxIndex);

//    left++;
//    right--;
//}