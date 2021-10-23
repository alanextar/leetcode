using leetcode;
using System;
using Xunit;

namespace xUnitTests
{
	public class Squares_of_a_Sorted_Array_Tests
	{
		[Fact]
		public void BigMixedSequenceTest()
		{
			var sln = new Squares_of_a_Sorted_Array();
			var copyArr = new int[Squares_of_a_Sorted_Array.bigMixedSeq.Length];
			Squares_of_a_Sorted_Array.bigMixedSeq.CopyTo(copyArr, 0);

			var expectedArray = sln.SortedSquaresTrivial(Squares_of_a_Sorted_Array.bigMixedSeq);
			var myResultedArr = sln.SortedSquares(copyArr);

			//Assert.Equal(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.Equal(expectedArray, myResultedArr);
		}

		[Fact]
		public void WithOneTest()
		{
			var sln = new Squares_of_a_Sorted_Array();
			var copyArr = new int[Squares_of_a_Sorted_Array.withOne.Length];
			Squares_of_a_Sorted_Array.withOne.CopyTo(copyArr, 0);

			var myResultedArr = sln.SortedSquares(copyArr);
			var expectedArray = sln.SortedSquaresTrivial(Squares_of_a_Sorted_Array.withOne);

			//Assert.Equal(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.Equal(expectedArray, myResultedArr);
		}

		[Fact]
		public void MixedSaSarrayTest()
		{
			var sln = new Squares_of_a_Sorted_Array();
			var copyArr = new int[Squares_of_a_Sorted_Array.mixed.Length];
			Squares_of_a_Sorted_Array.mixed.CopyTo(copyArr, 0);

			var myResultedArr = sln.SortedSquares(Squares_of_a_Sorted_Array.mixed);
			var expectedArr = sln.SortedSquaresTrivial(copyArr);

			//Assert.Equal(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.Equal(expectedArr, myResultedArr);
		}

		[Fact]
		public void MixedWithDuplicates()
		{
			var sln = new Squares_of_a_Sorted_Array();
			var myResultedArr = sln.SortedSquares(Squares_of_a_Sorted_Array.mixedWithDuplicates);
			var expectedArr = sln.SortedSquaresTrivial(Squares_of_a_Sorted_Array.mixedWithDuplicates);

			//Assert.Equal(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.Equal(expectedArr, myResultedArr);
		}

		[Fact]
		public void MixedWithManyDuplicates()
		{
			var sln = new Squares_of_a_Sorted_Array();
			var copyArr = new int[Squares_of_a_Sorted_Array.mixedWithManyDuplicates.Length];
			Squares_of_a_Sorted_Array.mixedWithManyDuplicates.CopyTo(copyArr, 0);

			var myResultedArr = sln.SortedSquares(Squares_of_a_Sorted_Array.mixedWithManyDuplicates);
			var expectedArr = sln.SortedSquaresTrivial(copyArr);

			//Assert.Equal(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
			Assert.Equal(expectedArr, myResultedArr);
		}

		[Fact]
		public void AllNegativeSaSarrayTest()
		{
			var sln = new Squares_of_a_Sorted_Array();
			var copyArr = new int[Squares_of_a_Sorted_Array.allNegative.Length];
			Squares_of_a_Sorted_Array.allNegative.CopyTo(copyArr, 0);

			var myResultedArr = sln.SortedSquares(copyArr);
			var expectedArr = sln.SortedSquaresTrivial(Squares_of_a_Sorted_Array.allNegative);

			Assert.Equal(expectedArr, myResultedArr);
		}

		[Fact]
		public void AllPositiveSaSarrayTest()
		{
			var sln = new Squares_of_a_Sorted_Array();

			var copyArr = new int[Squares_of_a_Sorted_Array.allPositive.Length];
			Squares_of_a_Sorted_Array.allPositive.CopyTo(copyArr, 0);

			var myResultedArr = sln.SortedSquares(copyArr);
			var expectedArr = sln.SortedSquaresTrivial(Squares_of_a_Sorted_Array.allPositive);

			Assert.Equal(expectedArr, myResultedArr);
		}

		[Fact]
		public void SameSignWithZeroFirstOrLast()
		{
			var sln = new Squares_of_a_Sorted_Array();

			var copyArr = new int[Squares_of_a_Sorted_Array.allPositiveWithZero.Length];
			Squares_of_a_Sorted_Array.allPositiveWithZero.CopyTo(copyArr, 0);

			var copyArr2 = new int[Squares_of_a_Sorted_Array.allNegativeWithZero.Length];
			Squares_of_a_Sorted_Array.allNegativeWithZero.CopyTo(copyArr2, 0);

			var allPositiveWithZero = sln.SortedSquares(copyArr);
			var allPositiveWithZeroRight = sln.SortedSquaresTrivial(Squares_of_a_Sorted_Array.allPositiveWithZero);

			var allNegativeWithZero = sln.SortedSquares(copyArr2);
			var allNegativeWithZeroRight = sln.SortedSquaresTrivial(Squares_of_a_Sorted_Array.allNegativeWithZero);

			Assert.Equal(allPositiveWithZero, allPositiveWithZeroRight);
			Assert.Equal(allNegativeWithZero, allNegativeWithZeroRight);
		}
	}

	public static class ArrExtensions
	{
		public static int[] CopyArr(this int[] arr)
		{
			var copyArr = new int[arr.Length];
			arr.CopyTo(copyArr, 0);

			return copyArr;
		}
	}
}
