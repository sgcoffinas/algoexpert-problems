using System;
using System.Collections.Generic;

public class Program 
{
	public static List<int> SpiralTraverse(int[,] array) 
	{
		var elements = new List<int>();
		var firstRow = 0;
		var firstCol = 0;
		var lastRow = array.GetLength(0) - 1;
		var lastCol = array.GetLength(1) - 1;
		
		while (firstRow <= lastRow && firstCol <= lastCol)
		{
			for (int i = firstCol; i <= lastCol; i++)
			{
				elements.Add(array[firstRow, i]);
			}
			for (int i = firstRow + 1; i <= lastRow; i++)
			{
				elements.Add(array[i, lastCol]);
			}
			for (int i = lastCol - 1; i >= firstCol; i--)
			{
				if (firstRow == lastRow) break;
				elements.Add(array[lastRow, i]);
			}
			for (int i = lastRow - 1; i > firstRow; i--)
			{
				if (firstCol == lastCol) break;
				elements.Add(array[i, firstCol]);
			}
			
			firstRow++;
			firstCol++;
			lastRow--;
			lastCol--;
		}
		
		return elements;
	}
}