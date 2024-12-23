/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MinimumOperations(TreeNode root)
		{
			Queue<TreeNode> queue = new Queue<TreeNode>();
			int totalSwaps = 0;
			queue.Enqueue(root);

			while (queue.Count > 0)
			{
				int size = queue.Count;
				int[] levelValues = new int[size];
				for (int i = 0; i < size; i++)
				{
					TreeNode node = queue.Dequeue();
					levelValues[i] = node.val;
					if (node.left != null)
						queue.Enqueue(node.left);
					if (node.right != null)
						queue.Enqueue(node.right);
				}

				totalSwaps += getMinSwapsForLevel(levelValues);
			}

			return totalSwaps;
		}

		private int getMinSwapsForLevel(int[] levelValues)
		{
			int swaps = 0;

			int[] target = new int[levelValues.Length];
			Array.Copy(levelValues, target, target.Length);
			Array.Sort(target);
			
			Dictionary<int, int> positions = new Dictionary<int, int>();
			for (int i = 0; i < target.Length; i++)
			{
				positions.Add(levelValues[i], i);
			}

			for (int i = 0; i < levelValues.Length; i++)
			{
				if (levelValues[i] != target[i])
				{
					swaps++;

					int curPos = positions[target[i]];
					positions[levelValues[i]] = curPos;
					int temp = levelValues[curPos];
					levelValues[curPos] = levelValues[i];
					levelValues[i] = temp;
				}
			}

			return swaps;
		}
}