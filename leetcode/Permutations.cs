using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    public class Permutations
    {
        public static int[] threeNumber = Enumerable.Range(1, 3).ToArray();
        public static int[] fourNumber = Enumerable.Range(1, 4).ToArray();
        public static int[] fiveNumbers = Enumerable.Range(1, 5).ToArray();
        public List<IList<int>> result;
        private int[] origin;

        public IList<IList<int>> Permute(int[] nums)
        {
            result = new List<IList<int>>();
            var left = nums.Length - 4;
            origin = new int[nums.Length];
            Array.Copy(nums, origin, nums.Length);

            while (left >= 0)
            {
                nums.SwapValues(left, nums.Length - 4);
                PermuteSubarray(nums);
                for (int i = nums.Length - 3; i < nums.Length; i++)
				{
                    nums.SwapValues(nums.Length - 4, i);
                    PermuteSubarray(nums);
                }
                
                left--;
            }

            return result;
        }

        void PermuteSubarray(int[] nums)
        {
            result.Add(nums.ToList());

            for (int i = nums.Length - 3 ; i < nums.Length; i++)
            {
                var newArr = new int[nums.Length];
                Array.Copy(nums, newArr, nums.Length);
                if (i > nums.Length - 3)
                {
                    newArr.SwapValues(nums.Length - 3, i);
                    result.Add(newArr.ToList());
                }
                
                newArr.SwapValues(nums.Length - 2, nums.Length - 1);
                result.Add(newArr.ToList());
            }
        }
        
    }
}
