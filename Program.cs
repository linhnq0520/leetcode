using System.Globalization;
using leetcode;

public class Program
{
	private static async Task Main(string[] args)
	{
		var testTask = new TestTask();
		//chạy song song
		Task t1 = testTask.T1();
		Task t2 = testTask.T2();
		await t1;
		await t2;
		// chạy đồng bộ
		// await testTask.T1();
		// await testTask.T2();
	}
	// private static async Task Main2(string[] args)
	// {
	// 	var testTask = new TestTask();
	// 	var t1 = testTask.T1();
	// 	var t2 = testTask.T2();
	// 	await Task.WhenAll(t1, t2);

	// 	Console.WriteLine(await t1);
	// 	Console.WriteLine(await t2);
	// }

	// private static async Task Main(string[] args)
	// {
	// 	var testTask = new TestTask();
	// 	var t1 = Task.Run(() => testTask.T1());
	// 	var t2 = Task.Run(testTask.T2);
	// 	await Task.WhenAll(t1, t2);
	// }

	public static void ProcessDate(string dateTime)
	{
		try
		{
			var date = DateTime.ParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
			var fiveYearsAgo = date.AddDays(-1825);
			Console.WriteLine(fiveYearsAgo.ToString());
		}
		catch (FormatException)
		{
			Console.WriteLine("Invalid date format. Please provide a date in the format 'dd/MM/yyyy'.");
		}
		catch (Exception ex)
		{
			Console.WriteLine("An error occurred: " + ex.Message);
		}
	}


}


public class Solution
{
	public bool CanPlaceFlowers(int[] flowerbed, int n)
	{
		var length = flowerbed.Length;
		if (length < 1 || length > 2 * (int)Math.Pow(10, 4))
		{
			throw new ArgumentException("Invalid flowerbed");
		}
		var count = 0;
		var list = new List<int>();
		for (var i = 0; i < length; i++)
		{
			if (flowerbed[i] == 0) list.Add(i);
		}
		if (list.Contains(0))
		{
			list = list.Where(s => s % 2 == 0).ToList();
			count = list.Count();
		}
		else
		{
			list = list.Where(s => s % 2 == 0).ToList();
			count = list.Count();
		}
		if (length > 2)
		{
			foreach (var item in list)
			{
				Console.WriteLine($"item-{item}={flowerbed[item]}");
				// var indexCheck = item >= length - 1 ? item - 1 : item + 1;
				// if (flowerbed[indexCheck] == 1) count = count - 1;
				if (item == length - 1)
				{
					if (flowerbed[item - 1] == 1) count = count - 1;
				}
				else if (item == 0)
				{
					if (flowerbed[item + 1] == 1) count = count - 1;
				}
				else
				{
					if (flowerbed[item + 1] == 1 || flowerbed[item - 1] == 1) count = count - 1;
				}

			}
		}
		Console.WriteLine("count=" + count);
		return count >= n;
	}

	public string MergeAlternately(string word1, string word2)
	{
		var length = word1.Length > word2.Length ? word1.Length : word2.Length;
		// var word1Array = word1.ToCharArray();
		// var word2Array = word2.ToCharArray();
		var response = string.Empty;
		for (var i = 0; i < length; i++)
		{
			if (i < word1.Length)
			{
				response += word1[i];
			}
			if (i < word2.Length)
			{
				response += word2[i];
			}
		}
		return response;
	}

	public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
	{
		var length = candies.Length;
		var result = new bool[length];
		var maxCandy = candies.Max();
		for (var i = 0; i < length; i++)
		{
			if (candies[i] + extraCandies >= maxCandy)
			{
				result[i] = true;
			}
			else
			{
				result[i] = false;
			}
		}
		return result;
	}
}