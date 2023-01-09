using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String
{
    internal class _520
    {
        public bool DetectCapitalUse_Sln1(string word) {
            var allNotCapitals = true;
            var onlyFirstCapital = false;
            var allCapitals = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0 && char.IsUpper(word[i]))
                {
                    onlyFirstCapital = true;
                    allCapitals = true;
                }
                else if (char.IsUpper(word[i]))
                {
                    allNotCapitals = false;
                    onlyFirstCapital = false;
                    allNotCapitals = false;
                }
                else
                {
                    allCapitals = false;
                }
                    
            }

            return allNotCapitals || onlyFirstCapital || allCapitals;
        }

        public bool DetectCapitalUse(string word) {
            var isFirstUpperChar = IsUpperChar(word[0]);
            var allNotCapitals = !isFirstUpperChar;
            var onlyFirstCapital = isFirstUpperChar;
            var allCapitals = isFirstUpperChar;

            for (int i = 1; i < word.Length; i++)
            {
                if (!allCapitals && !allNotCapitals && !onlyFirstCapital)
                {
                    return false;
                }

                if (IsUpperChar(word[i]))
                {
                    allNotCapitals = false;
                    onlyFirstCapital = false;
                }
                else
                {
                    allCapitals = false;
                }
                    
            }

            return allNotCapitals || onlyFirstCapital || allCapitals;
        }

        private bool IsUpperChar(char c)
        {
            return (c >= 'A' && c <= 'Z');
        }
    }

    public static class Program520
    {
        public static void Main_520(string[] args)
        {
            var s = new _520();

            Assert.AreEqual(true, s.DetectCapitalUse("Leetcode"));
            Assert.AreEqual(false, s.DetectCapitalUse("FlaG"));
            Assert.AreEqual(true, s.DetectCapitalUse("RUSSIA"));
            Assert.AreEqual(true, s.DetectCapitalUse("russia"));
        }
    }
}
