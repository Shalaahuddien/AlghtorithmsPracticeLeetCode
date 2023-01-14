public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int n = nums.Length;
        int res=0;
        for(int i=0;i<n-2;i++){
            for(int j = i+1;j<n-1;j++){
                if(nums[j]-nums[i] > diff) break;
                if(nums[j] - nums[i] == diff){
                    for(int k =j+1;k<n;k++){
                        if(nums[k]-nums[j] > diff) break;
                        if(nums[k] - nums[j] == diff) res+=1;
                    }
                }
            }
        }
        return res;
        
    }
}