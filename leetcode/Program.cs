using leetcode.Array;
using leetcode.BinaryTree;
using leetcode.LinkedList;
using leetcode.StackQueue;
using leetcode.String;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace leetcode
{
	//class Program
	//{
	//	static void Main(string[] args)
	//	{
	//		"abcdef".AsParallel().Select(c => char.ToUpper(c)).ForAll(Console.Write);
	//		int[] numbers = { 3, 4, 5, 6, 7, 8, 9 };
	//		var parallelQuery =
	//		   Partitioner.Create(numbers, true).AsParallel();

	//		IEnumerable<int> million = Enumerable.Range(3, 1000000);


	//		var cancelSource = new CancellationTokenSource(); 
	//		var primeNumberQuery =
	//		   from n in million
 //              .AsParallel()
	//		   //.WithDegreeOfParallelism(4)
 //                  //.WithCancellation(cancelSource.Token)
 //              where Enumerable.Range(2, (int)Math.Sqrt(n)).All(i => n % i > 0)
	//		   select n;

	//		new Thread(() => {
	//			Thread.Sleep(450);      // Отмена запроса через
	//			cancelSource.Cancel();   // 100 миллисекунд.
	//		}).Start();

	//		var sw = new Stopwatch();
	//		sw.Start();

	//		try
	//		{
	//			// Запуск запроса в работу:
	//			int[] primes = primeNumberQuery.ToArray();
 //               Console.WriteLine("Сюда мы никогда не попадем, потому что другой поток отменит работу этого кода.");
	//			// Сюда мы никогда не попадем, потому что другой поток отменит работу этого кода.
	//		}

	//		catch (OperationCanceledException)
	//		{
	//			Console.WriteLine("Запрос отменен");
	//		}

	//		sw.Stop();
 //           Console.WriteLine($"Time: {sw.ElapsedMilliseconds}");

	//		//CombinationIteratorProgram.CombinationIteratorProgramMain(null);

	//		Console.WriteLine("Hello World!");
	//	}
	//}

	class Problem1
	{
		static void AMain(string[] args)
		{
			var s = "1234";
			var sw = new Stopwatch();
			sw.Start();
			var r2 = InjectSpaces2(s); // r == "1 2 3 4"
			sw.Stop();
			Console.WriteLine(sw.ElapsedMilliseconds);
			sw.Restart();
			var r = InjectSpaces(s); // r == "1 2 3 4"
			sw.Stop();
			Console.WriteLine(sw.ElapsedMilliseconds);
		}

		static string InjectSpaces(string s)
		{
			// 1. Return s with a single space injected between any pair of adjacent characters.
			// 2. Make sure it works as fast as possible.
			var spacedStr = string.Join(' ', s.ToArray());

			return spacedStr;
		}

		static string InjectSpaces2(string s)
		{
			// 1. Return s with a single space injected between any pair of adjacent characters.
			// 2. Make sure it works as fast as possible.
			var spacedStr = string.Join(' ', s.ToArray());
			var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
					sb.Append(s[i]);
                }
                else{
					sb.Append(s[i] + " ");
				}
				
            }

			return sb.ToString();
		}
	}
}
