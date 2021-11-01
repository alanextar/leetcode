using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
	class Program
	{
		static void Main(string[] args)
		{
			var permutations = new Permutations();
            //var result1 = permutations.Permute(Permutations.threeNumber);
            //var result2 = permutations.Permute(Permutations.fourNumber);
            var result3 = permutations.Permute(Permutations.fiveNumbers);

			Console.WriteLine("Hello World!");
		}
	}

	public interface IItemDto
	{
		int ItemId { get; set; }
		string ItemPreviewPath { get; set; }
	}
	
	public class ItemDto : IItemDto
	{
		public int ItemId { get; set; }
		public string ItemPreviewPath { get; set; }
		//далее идут другие свойства
	}

	class MyClass
	{
		public ICollection<ItemDto> Items { get; set; }
		public void AddPreviewsToItemDtos<IItemDto>(ICollection<IItemDto> items)
		{
			//здесь код, обращающийся к БД и получающий коллекцию ItemPreviewPath на основании коллекции, сформированной из имеющихся ItemId
		}
	}
	
}
