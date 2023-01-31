/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if (root==null) return root; 
        Queue<Node> levelQu = new();
        int LevelCount =1;
        levelQu.Enqueue(root);
        while(levelQu.Count>0){
            List<Node> OldLevel = new();
            int newLevelCount = 0;
            for(int i=0;i<LevelCount;i++){
                Node temp = levelQu.Dequeue();
                OldLevel.Add(temp);
                if(temp.left != null){
                    levelQu.Enqueue(temp.left);
                    newLevelCount+=1;
                }
                if(temp.right != null){
                    levelQu.Enqueue(temp.right);
                     newLevelCount+=1;
                }
            }
            for(int i=0;i<OldLevel.Count-1;i++){
                OldLevel[i].next = OldLevel[i+1];
                Console.WriteLine($"Connect {OldLevel[i].val}-->{OldLevel[i+1].val}");
            }
            LevelCount =newLevelCount;
            
        }
        
        
        
        return root;
    }

}