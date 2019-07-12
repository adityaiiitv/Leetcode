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
    int sum = 0;
    public int RangeSumBST(TreeNode root, int L, int R) {
        Helper(root, L, R);
        return sum;
    }
    public void Helper(TreeNode root, int L, int R)
    {
        if(root!=null && root.val>=L && root.val<=R)
        {
            sum+=root.val;
        }
        if(root.left!=null)
        {
            Helper(root.left, L, R);   
        }
        if(root.right!=null)
        {
            Helper(root.right, L, R);   
        }
    }
}