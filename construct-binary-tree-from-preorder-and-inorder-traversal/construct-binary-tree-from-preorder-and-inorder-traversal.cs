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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Build(preorder,inorder);
    }
    public TreeNode Build(int[] preorder, int[] inorder){
        if(inorder.Length ==0){
            return null;
        }
        if(inorder.Length ==1){
            TreeNode res = new TreeNode(inorder[0]);
            return res;
        }
        TreeNode root = new();
        int n = inorder.Length;
        
        int rv = preorder[0];
        root.val = rv;
        int rvIndex = Array.IndexOf(inorder,rv);
        
        int[] leftPr = preorder[1..(rvIndex+1)];
        int[] leftIn = inorder[0..rvIndex];
        
        int[] rightPr = preorder[(rvIndex+1)..n];
        int[] rightIn = inorder[(rvIndex+1)..n];
        
        root.left = BuildTree(leftPr,leftIn);
        root.right = BuildTree(rightPr,rightIn);
        return root;
        
    }
    public void print(IEnumerable<int> arr){
        Console.Write("[");
        foreach(int x in arr)Console.Write($" {x} ");
        Console.WriteLine("]");
    }
}
