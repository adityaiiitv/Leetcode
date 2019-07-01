/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System;
using System.Collections.Generic;
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> lol = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if(root==null)
        {
            return lol;
        }
        q.Enqueue(root);
        TreeNode temp = new TreeNode(0);
        while(q.Any())
        {
            int l = q.Count;
            IList<int> li = new List<int>();
            for(int i=0;i<l;i++)
            {
                temp = q.Dequeue();
                li.Add(temp.val);
                if(temp.left!=null)
                {
                    q.Enqueue(temp.left);
                }
                if(temp.right!=null)
                {
                    q.Enqueue(temp.right);
                }
            }
            lol.Add(li);
        }
        return lol;
    }
}