using System;

public class Program 
{
	public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo) 
	{
		Array.Sort(arrayOne);
		Array.Sort(arrayTwo);
		
		var oneIndex = 0;
		var twoIndex = 0;
		var smallest = Int32.MaxValue;
		var current = Int32.MaxValue;
		int[] result = new int[2];
		while (oneIndex < arrayOne.Length && twoIndex < arrayTwo.Length)
		{
			var first = arrayOne[oneIndex];
			var second = arrayTwo[twoIndex];
			
			if (first > second) 
			{
				current = first - second;
				twoIndex++;
			} else if (second > first) 
			{
				current = second - first;
				oneIndex++;
			} else 
			{
				return new int[] {first, second};
			}
			
			if (current < smallest) 
			{
				smallest = current;
				result = new int[] {first, second};
			}
		}
		return result;
	}
}