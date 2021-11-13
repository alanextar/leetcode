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
                System.Array.Copy(nums, newArr, nums.Length);
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

    //https://leetcode.com/problems/permutations/discuss/586822/C-solution
    public class LeetcodePermutations
    {
        public static int[] threeNumber = Enumerable.Range(1, 3).ToArray();
        public static int[] fourNumber = Enumerable.Range(1, 4).ToArray();
        public static int[] fiveNumbers = Enumerable.Range(1, 5).ToArray();

        public IList<IList<int>> Permute(int[] nums)
        {

            List<IList<int>> res = new List<IList<int>>();
            Backtracking(nums, new List<int>(), res);
            return res;
        }

        private void Backtracking(int[] nums, List<int> list, List<IList<int>> res)
        {
            if (list.Count == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (list.Contains(nums[i]))
                        continue;
                    list.Add(nums[i]);
                    Backtracking(nums, list, res);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
