public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int res=0;
        foreach(string s in operations)
            if(s =="++X" || s== "X++") res+=1;
            else res-=1;
        return res;
    }
}