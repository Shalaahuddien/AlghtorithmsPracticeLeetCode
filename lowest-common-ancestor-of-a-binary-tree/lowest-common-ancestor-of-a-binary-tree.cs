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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        Dictionary<TreeNode,TreeNode> parents = new();
        Stack<TreeNode> st = new();
        st.Push(root);
        parents[root] = root;
        while(st.Count>0){
            TreeNode now = st.Pop();
            Console.WriteLine($"NOw visit {now.val}");
            if(now.left!=null){
                st.Push(now.left);
                parents[now.left]= now;
            }
            if(now.right!=null){
                st.Push(now.right);
                 parents[now.right]= now;
            }
        }
        List<TreeNode> Qpath = new();
        TreeNode temp=q;
        Console.Write($"Qpath : ");
        while(temp!=root){
            Qpath.Add(temp);
            Console.Write($" {temp.val}->");
            temp=parents[temp];
        }
        Qpath.Add(temp);
        Console.WriteLine();
        List<TreeNode> Ppath = new();
        temp=p;
        Console.Write($"Ppath : ");
        while(temp!=root){
            Ppath.Add(temp);
            Console.Write($" {temp.val}->");
            temp=parents[temp];
        }
        Ppath.Add(temp);
        Console.WriteLine();
        Ppath.Reverse();
        Qpath.Reverse();
        int n = Math.Min(Ppath.Count,Qpath.Count);
        for(int i=0;i<n;i++){
            if (i==n-1 && Ppath[i].val ==Qpath[i].val){
                return Ppath[i];
            }
            if (Ppath[i].val !=Qpath[i].val)
                return Ppath[i-1];
        }
        return root;
        
    }
}