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
     bool result =true;
    public bool IsBalanced(TreeNode root) {
        GetSubTreeHeight(root);
        return result;
    }

    public int GetSubTreeHeight(TreeNode tree){
        if(tree ==null){
            return 0;
        }

        var ltreeheight=GetSubTreeHeight(tree.left);
        var rtreeheight=GetSubTreeHeight(tree.right);
        if(Math.Abs(rtreeheight-ltreeheight)>1){
          result= false;
        }

        var maxtree=Math.Max(ltreeheight,rtreeheight);
        return maxtree+1;
    }

}
