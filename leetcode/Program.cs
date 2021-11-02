using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			var permutations = new LeetcodePermutations();
			var result1 = permutations.Permute(LeetcodePermutations.threeNumber);
			//var result2 = permutations.Permute(Permutations.fourNumber);
			//var result3 = permutations.Permute(Permutations.fiveNumbers);

			Console.WriteLine("Hello World!");
		}
	}
	
}
