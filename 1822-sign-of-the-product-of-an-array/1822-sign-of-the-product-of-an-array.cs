public class Solution {
    public int ArraySign(int[] nums) {
        int  res=1;
        foreach(int x in nums){
            if(x<0)
                res*=-1;
            if (x==0) return 0;
        }
        return res;
    }
}