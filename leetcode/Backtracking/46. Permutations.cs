using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Backtracking
{
    public static class Program_46
    {
        public static void Main_46(string[] args)
        {
            var s = new _46();

            s.Permute(new int[] {1,2,3});
            //s.Permute(new int[] {1,2,3});
            //s.Permute(new int[] {0, 1});
            //s.Permute(new int[] {1});
        }
    }

    internal class _46
    {
        public IList<IList<int>> Permute(int[] nums) {
            var res = new List<IList<int>>();
            if (nums.Length == 1)
            {
                res.Add(nums);
                return res;
            }

            Helper(nums, res, 0);
            //Print(res);

            return res;
        }

        private void Helper(int[] nums, IList<IList<int>> res, int pos)
        {
            if (pos == nums.Length)
            {
                res.Add(nums.ToList());
                return;
            }

            for (int i = pos; i < nums.Length; i++)
            {
                Swap(nums, i, pos);
                Helper(nums, res, pos + 1);
                Swap(nums, i, pos);
            }
        }

        private void Swap(int[] nums, int i1, int i2)
        {
            var temp = nums[i1];
            nums[i1] = nums[i2];
            nums[i2] = temp;
        }

        private void Print(IList<IList<int>> res)
        {
            foreach (var nums in res)
            {
                Console.WriteLine(System.String.Join(", ", nums));
            }
        }
    }
}
