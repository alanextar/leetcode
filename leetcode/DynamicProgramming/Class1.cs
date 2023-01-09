using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DynamicProgramming
{
    // failed
    internal class _1143
    {
        public int LongestCommonSubsequence(string s1, string s2) {
            int[,] dp = new int[s1.Length+1,s2.Length+1];
            for(int i=1;i<=s1.Length;i++){
                for(int j=1;j<=s2.Length;j++){
                    if(s1[i-1]==s2[j-1]){
                        dp[i,j] = dp[i-1,j-1]+1;
                    }
                    else{
                        dp[i,j] = Math.Max(dp[i-1,j],dp[i,j-1]);
                    }
                }
            }
            return dp[s1.Length,s2.Length];
        }

        public int UstinovSolutionLongestCommonSubsequence(string text1, string text2) {
            if (text1.Length < text2.Length) {
                (text1, text2) = (text2, text1);
            }
            var text1Len = text1.Length;
            var (dpPrev, dp) = (new int[text1Len], new int[text1Len]);
            foreach(var c in text2) {
                (dpPrev, dp) = (dp, dpPrev);
                for (var i=0; i < text1Len; i++) {
                    dp[i] = text1[i]==c
                        ? i > 0 ? dpPrev[i-1] + 1 : 1 
                        : Math.Max(i > 0 ? dp[i-1] : 0, dpPrev[i]);
                }
            }
            return dp[text1Len - 1];
        }
    }

    public static class Program_1143
    {
        public static void Main_1143(string[] args)
        {
            var s = new _1143();
            //var r1 = s.LongestCommonSubsequence("adbec", "abc");
            var r2 = s.UstinovSolutionLongestCommonSubsequence("adbec", "abc");
        }
    }
}
