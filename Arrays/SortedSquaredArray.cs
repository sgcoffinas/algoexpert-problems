using System;

public class Program 
{
	public int[] SortedSquaredArray(int[] array) 
	{
		var squaredSorted = new int[array.Length];
		var smallestIndex = 0;
		var largestIndex = array.Length - 1;

		for (int i = array.Length - 1; i >= 0; i--) 
		{
			var smallest = array[smallestIndex];
			var largest = array[largestIndex];
			
			if (Math.Abs(largest) > Math.Abs(smallest)) 
			{
				squaredSorted[i] = largest * largest;
				largestIndex--;
			} else 
			{
				squaredSorted[i] = smallest * smallest;
				smallestIndex++;
			}
		}
		
		return squaredSorted;
	}
}