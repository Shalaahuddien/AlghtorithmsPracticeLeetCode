public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        HashSet<int> nums2 = new HashSet<int>(nums);
        int n = nums.Length;
        int res=0;
        for(int i=0;i<n;i++){
            if(nums2.Contains(nums[i]+diff) && nums2.Contains(nums[i]-diff))
                res+=1;
        }
        return res;
        
    }
}