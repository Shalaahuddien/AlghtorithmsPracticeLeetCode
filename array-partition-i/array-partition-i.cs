public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int res=0;
        for(int i=0;i<nums.Length;i+=2)res+=nums[i];
        return res;
    }
}