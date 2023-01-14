public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        List<int> nums2 = nums.ToList();
        int n = nums.Length;
        int res=0;
        for(int i=0;i<n;i++){
            if(nums2.Contains(nums2[i]+diff) && nums2.Contains(nums2[i]-diff))
                res+=1;
        }
        return res;
        
    }
}