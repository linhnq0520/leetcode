public class Program
{
	private static void Main(string[] args)
	{
		var solution = new Solution();
		Console.WriteLine("Hello, World!");
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

		return count == n;
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