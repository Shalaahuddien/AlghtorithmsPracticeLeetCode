public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        Array.Reverse(nums);
        int n=nums.Length;
        for(int i =0;i<n-2;i++){
            for(int j=i+1;j<n-1;j++){
                for(int k=j+1;k<n;k++){
                    if( nums[k] < nums[i]+nums[j] &&  nums[j] < nums[i]+nums[k]&& nums[i] < nums[j]+nums[k])
                        return nums[i]+nums[j]+nums[k];
                }
            }
        }
        return 0;
    }
}