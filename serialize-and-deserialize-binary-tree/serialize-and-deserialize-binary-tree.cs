/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null) 
            return "";
        List<string> s =new ();
        Queue<TreeNode> BFS= new();
        BFS.Enqueue(root);
        s.Add($"{root.val}");
        while(BFS.Count>0){
            TreeNode now = BFS.Dequeue();
            if(now.left == null) s.Add("#");
            else {
                s.Add(now.left.val.ToString());
                BFS.Enqueue(now.left);
            }
            if(now.right == null) s.Add("#");
            else {
                s.Add(now.right.val.ToString());
                BFS.Enqueue(now.right);
            }
        }
        for(int i =s.Count-1;i>=0;i--){
            if (s[i]=="#") s.RemoveAt(i);
            else break;
        }
        string res = String.Join(",",s);
        //Console.WriteLine(res);
        return res;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data.Length ==0) return null;
        String[] datas = data.Split(",");
        Queue<TreeNode> LastLevel = new();
        TreeNode root = new(int.Parse(datas[0]));
        LastLevel.Enqueue(root);
        int i = 1;
        while(LastLevel.Count>0){
            if(i >=datas.Length)break;
            TreeNode current = LastLevel.Dequeue();
            string s1 = datas[i];
            if (s1!="#"){
                TreeNode t1 = new TreeNode(int.Parse(s1));
                LastLevel.Enqueue(t1);
                current.left = t1;
            }
            if (i+1<datas.Length && datas[i+1]!="#"){
                TreeNode t2 = new TreeNode(int.Parse(datas[i+1]));
                LastLevel.Enqueue(t2);
                current.right = t2;
            }
            
            //foreach(var x in LastLevel) Console.Write($" {x.val}" );
           // Console.WriteLine();
            i+=2;
        }
        
        
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));