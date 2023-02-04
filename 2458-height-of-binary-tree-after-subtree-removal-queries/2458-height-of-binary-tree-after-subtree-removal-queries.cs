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
    Dictionary<int,List<int>> levels;
    Dictionary<int,int> lengthAfterAndBefor;
    Dictionary<int,int> myLevel;
    int n =0;
    public int[] TreeQueries(TreeNode root, int[] queries) {
        levels = new Dictionary<int,List<int>> ();
        lengthAfterAndBefor = new Dictionary<int,int>();
        myLevel = new Dictionary<int,int>();
        int[] res = new int[queries.Length];
        TheLongAfter(root,-1);
        Dictionary<int,int[]> O1 = new();
        for(int i=0;i<levels.Count;i++){
            int[] mxmx2 = new int[2];
            List<int> sameLevel = levels[i];
            int mx =i-1;
            int mx2= i-1;
            foreach(int x in sameLevel){
                if(lengthAfterAndBefor[x] >mx2){
                    if(lengthAfterAndBefor[x]>mx){
                         mx2=mx;
                         mx = lengthAfterAndBefor[x];
                    }
                    else{
                         mx2 = lengthAfterAndBefor[x];
                    }
                }
            }
            mxmx2[0] = mx;
            mxmx2[1] = mx2;
            O1[i] = mxmx2;
        }
        
        for(int i=0;i<queries.Length;i++){
            int toDelet = queries[i];
            int levelNum = myLevel[toDelet];
            int[] mxmx2 = O1[levelNum];
            if(lengthAfterAndBefor[toDelet] ==mxmx2[0])
                res[i] = mxmx2[1];
            else
                res[i] = mxmx2[0];
        }
        return res;
        
    }
    
    public int TheLongAfter(TreeNode root,int parentLevel){
        int thisLevel = parentLevel+1;
        myLevel[root.val] = thisLevel;
        if(!levels.ContainsKey(thisLevel))levels[thisLevel] =new List<int>();
        levels[thisLevel].Add(root.val);
        
        int lenLeft = -1;
        int lenRight= -1;
        if(root.left !=null){
            lenLeft = TheLongAfter(root.left,thisLevel);
        }
        if(root.right !=null){
            lenRight = TheLongAfter(root.right,thisLevel);
        }
        int lenAfter = Math.Max(lenLeft,lenRight) +1;
        
        lengthAfterAndBefor[root.val] = thisLevel + lenAfter;
        return lenAfter;
    }
}