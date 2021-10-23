using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			//var root = MaxDepthSolutions.InitTestCase1();
			//var maxDepthSln = new MaxDepthBinaryTreeMySolution();
			//var s = new Squares_of_a_Sorted_Array();
			//var sortedAndSquared = s.SortedSquaresTrivial(Squares_of_a_Sorted_Array.withOne);

			var mergeSln = new Merge_Intervals();
			var mergedIntervals =  mergeSln.MergeMySoultion(Merge_Intervals.intervals1);
			mergedIntervals =  mergeSln.MergeMySoultion(Merge_Intervals.empty);
			mergedIntervals =  mergeSln.MergeMySoultion(Merge_Intervals.twoInterval);

			Console.WriteLine("Hello World!");
		}
	}

}
