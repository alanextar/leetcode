using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			var parenthesisSln = new Valid_Parentheses();
			var isValid1 = parenthesisSln.IsValid(Valid_Parentheses.validCase1);
			var isValid2 = parenthesisSln.IsValid(Valid_Parentheses.validCase2);
			var isValid3 = parenthesisSln.IsValid(Valid_Parentheses.inValidCase1);
			var isValid4 = parenthesisSln.IsValid(Valid_Parentheses.inValidCase2);
			var isValid5 = parenthesisSln.IsValid(Valid_Parentheses.inValidCase3);

			Console.WriteLine("Hello World!");
		}
	}
}
