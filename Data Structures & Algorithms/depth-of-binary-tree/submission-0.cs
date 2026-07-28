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
    public int MaxDepth(TreeNode root) {
        if(root==null){
            return 0;
        }
        var nodeq = new Queue<TreeNode>();
        nodeq.Enqueue(root);
        var height =0;
        while(nodeq.Count()>0){
            
            var size = nodeq.Count();
            for(int i=0;i<size;i++){
                var node = nodeq.Dequeue();
                if(node.left!=null){
                    nodeq.Enqueue(node.left);
                }
                if(node.right!=null){
                    nodeq.Enqueue(node.right);
                }
            }
            height++;
        }
        return height;

    }
}
