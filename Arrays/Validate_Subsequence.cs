using System;
using System.Collections.Generic;

public class Program 
{
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) 
	{
		var sequenceIndexToCheck = 0;
		foreach (var num in array) 
		{
			if (sequence[sequenceIndexToCheck] == num) 
			{
				sequenceIndexToCheck++; 
				if (sequence.Count == sequenceIndexToCheck) return true;
			}
		}
		
		return false;
	}
}