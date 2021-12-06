using System;
using System.Collections.Generic;

public class Program 
{
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) 
    {
		Array.Sort(array);
		List<int[]> result = new List<int[]>();
		
		for (int i = 0; i < array.Length - 2; i++) 
        {
			var nextIndex = i + 1;
			var lastIndex = array.Length - 1;
			while (nextIndex < lastIndex) 
            {
				var sum = array[i] + array[nextIndex] + array[lastIndex];
				if (sum == targetSum) 
                {
					result.Add(new int[3]{array[i], array[nextIndex], array[lastIndex]});
					nextIndex++;
					lastIndex--;
				} else if (sum > targetSum) 
                {
					lastIndex--;
				} else 
                {
					nextIndex++;
				}
			}
		}
		
		return result;
	}
}