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
        TreeTravers(root);
        NullRight(root);
        return root;
    }
    public void TreeTravers(Node root){
        if (root==null) return;
        SetLeftRightNode(root);
        
    }
    public void SetLeftRightNode(Node root){
        if (root==null) return;
        Node leftPointer = root.left;
        Node RightPointer= root.right;
        LeftToRigth(leftPointer,RightPointer);
        SetLeftRightNode(root.left);
        SetLeftRightNode(root.right);
    }
    public void LeftToRigth(Node left,Node right){
        if (left==null) return;
        Console.WriteLine($"now {left.val} -> {right.val}");
        left.next = right;
        LeftToRigth(left.right,right.left);
    }
    public void NullRight(Node root){
        if (root==null) return;
        root.next = null;
        NullRight(root.right);
    }
}