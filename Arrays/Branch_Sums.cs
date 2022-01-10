using System;
using System.Collections.Generic;

public class Program 
{
	// This is the class of the input root. Do not edit it.
	public class BinaryTree 
	{
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) 
		{
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}

	public static List<int> BranchSums(BinaryTree root) 
	{
		List<int> sums = new List<int>();
		CalculateBranchSums(root, sums);
		return sums;
	}
	
	public static void CalculateBranchSums(BinaryTree bt, List<int> sums, int currentSum = 0)
	{
		if (bt == null) return;
		
		int newSum = currentSum + bt.value;
		if (bt.left == null && bt.right == null)
		{
			sums.Add(newSum);
			return;
		}
		
		CalculateBranchSums(bt.left, sums, newSum);
		CalculateBranchSums(bt.right, sums, newSum);
	}
}