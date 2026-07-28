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
    public TreeNode InvertTree(TreeNode root) {
         if(root==null){
            return root;
        }

        var nodeq = new Queue<TreeNode>();
        nodeq.Enqueue(root);
        TreeNode temp=null;
        while(nodeq.Count()>0){
            var node = nodeq.Dequeue();
            if(node.left!=null){
                nodeq.Enqueue(node.left);
            }
            if(node.right!=null){
                nodeq.Enqueue(node.right);
            }

            temp=node.right;
            node.right=node.left;
            node.left=temp;
        }
        return root;

        }




    }

