
public class Solution {
    IList<int> ans = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        Helper(root);
        return ans;
    }
    public void Helper(TreeNode root)
    {
        if(root!=null)
        {
            InorderTraversal(root.left);
            ans.Add(root.val);
            InorderTraversal(root.right);
        }
    }
}