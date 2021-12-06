using System;


public class Program 
{
	public int NonConstructibleChange(int[] coins) 
	{
		Array.Sort(coins);
		var maxChange = 0;
		
		foreach (var coin in coins) 
		{
			if (coin > maxChange + 1) 
			{
				return maxChange + 1;
			} 
			maxChange = maxChange + coin;
		}
		
		return maxChange + 1;
	}
}