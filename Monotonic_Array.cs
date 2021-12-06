using System;

public class Program 
{
	public static bool IsMonotonic(int[] array) 
	{
		if (array.Length <= 2) return true;
		bool trendsUp = true;
		bool trendsDown = true;
		
		for (int i = 0; i < array.Length - 1; i++)
		{
			if (array[i] - array[i+1] > 0) trendsDown = false;
			else if (array[i] - array[i+1] < 0) trendsUp = false;
		}
		
		return (trendsUp || trendsDown);
	}
}