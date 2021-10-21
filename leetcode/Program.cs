using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			var root = MaxDepthSolutions.InitTestCase1();
			var maxDepthSln = new MaxDepthBinaryTreeMySolution();
			var testCase1Depth = maxDepthSln.MaxDepth(root);

			Console.WriteLine("Hello World!");
		}
	}

}
