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
    public TreeNode ReverseOddLevels(TreeNode root) {
        DFS(ref root.left, ref root.right, true);
        return root;
    }
    
    public void DFS(ref TreeNode left, ref TreeNode right, bool flip)
    {
        if (left == null || right == null)
            return;

        if (flip)
        {
            int temp = left.val;
            left.val = right.val;
            right.val = temp;                
        }
        
        DFS(ref left.left, ref right.right, !flip);
        DFS(ref left.right, ref right.left, !flip);
    }
}