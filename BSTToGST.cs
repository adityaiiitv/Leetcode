/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    int curr_sum = 0;
    public TreeNode BstToGst(TreeNode root) {
        Helper(root);
        return root;
    }
    public void Helper(TreeNode root)
    {
        if(root.right!=null)
        {
            BstToGst(root.right);   
        }
        curr_sum+=root.val;
        root.val = curr_sum;
        if(root.left!=null)
        {
            BstToGst(root.left);   
        }
    }
}