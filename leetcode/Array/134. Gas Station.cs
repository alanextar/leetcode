using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    public static class Program_134
    {
        public static void Main_134(string[] args)
        {
            var s = new _134();

            Assert.AreEqual(3, s.CanCompleteCircuit(new int[] {1,2,3,4,5}, new int[] {3,4,5,1,2}));
            Assert.AreEqual(3, s.CanCompleteCircuit(new int[] {2,3,4}, new int[] {3,4,3}));
        }
    }

    internal class _134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost) {
            var tanks = new int[gas.Length];
            tanks[gas.Length-1] = gas[gas.Length-1] - cost[gas.Length-1];
            var start = -1;
            var cur = -1;
            var maxLength = 0;
            var length = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                tanks[i] = gas[i] - cost[i];
                if (tanks[i] > 0 && start == -1)
                {
                    start = i;
                    cur = i;
                    length++;
                }
                else if (tanks[i] > 0)
                {
                    length++;
                }
                else if(tanks[i] < 0)
                {
                    if (length > maxLength)
                    {
                        start = cur;
                        maxLength = length;
                    }
                    
                    cur = -1;
                    length = 0;
                }

            }

            var tank = gas[start];
            for (int i = start; i < gas.Length; i++)
            {
                tank = gas[i] - cost[i];
                if (tank < 0)
                {
                    return -1;
                }
                
                
            }

            for (int i = 0; i < start+1; i++)
            {
                tank -= cost[i-1];
                if (tank < 0)
                {
                    return -1;
                }
            }

            return start;
        }
    }
}
