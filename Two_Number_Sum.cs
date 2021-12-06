using System;
using System.Collections.Generic;

public class Program 
{
	public static int[] TwoNumberSum(int[] array, int targetSum) 
	{
		var numbers = new HashSet<int>();
		foreach (var num in array) 
		{
			int target = targetSum - num;
			if (numbers.Contains(target)) 
			{
				return new int[] {target, num};
			} else 
			{
				numbers.Add(num);
			}
		}
		
		return new int[0];
	}
}