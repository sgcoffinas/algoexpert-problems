using System;
using System.Collections.Generic;

public class Program 
{
	public static List<int> MoveElementToEnd(List<int> array, int toMove) 
	{
		int firstIndex = 0;
		int lastIndex = array.Count - 1;
		int swap = -1; 

		while (firstIndex < lastIndex)
		{
			if (array[firstIndex] == toMove)
			{
				swap = array[lastIndex];
				array[lastIndex] = toMove;
				array[firstIndex] = swap;
				lastIndex--;
			} else 
			{
				firstIndex++;
			}
		}
		
		return array;
	}
}