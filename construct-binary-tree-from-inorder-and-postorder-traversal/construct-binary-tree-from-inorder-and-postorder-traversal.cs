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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return Build(inorder,postorder);
    }
    public TreeNode Build(int[] inorder, int[] postorder){
        //Console.Write("inorder = ");
        //print(inorder);
        //Console.Write("posorder = ");
        //print(postorder);
        if(inorder.Length ==0){
            return null;
        }
        if(inorder.Length ==1){
            TreeNode res = new TreeNode(inorder[0]);
            return res;
        }
        TreeNode root = new();
        int n = inorder.Length;
        
        int rv = postorder[n-1];
        root.val = rv;
        int rvIndex = Array.IndexOf(inorder,rv);
        
        int[] leftIn = inorder[0..rvIndex];
        int[] leftPos = postorder[0..rvIndex];
        
        int[] rightIn = inorder[(rvIndex+1)..n];
        int[] rightPos = postorder[rvIndex..(n-1)];
        
        root.left = BuildTree(leftIn,leftPos);
        root.right = BuildTree(rightIn,rightPos);
        return root;
        
    }
    public void print(IEnumerable<int> arr){
        Console.Write("[");
        foreach(int x in arr)Console.Write($" {x} ");
        Console.WriteLine("]");
    }
}
