using System;

public class Program {
	public static int NodeDepths(BinaryTree root) 
	{
		return CalculateNodeDepths(root);
	}
	
	public static int CalculateNodeDepths(BinaryTree bt, int currentSum = 0)
	{
		if (bt == null) return 0;
		
		return currentSum + CalculateNodeDepths(bt.left, currentSum + 1) + CalculateNodeDepths(bt.right, currentSum + 1);
	}

	public class BinaryTree 
	{
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) 
		{
			this.value = value;
			left = null;
			right = null;
		}
	}
}