using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			var binarySearchSln = new Binary_Search();
			var sln1 = binarySearchSln.Search(Binary_Search.nums1, 2);
			var sln2 = binarySearchSln.Search(Binary_Search.nums2, 5);
			var sln3 = binarySearchSln.Search(Binary_Search.nums3, 2);

			Console.WriteLine("Hello World!");
		}
	}
}
