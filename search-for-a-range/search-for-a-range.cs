public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n = nums.Length;
        int l =0;
        int r = n-1;
        while(l<=r){
            int mid = l + (r-l)/2;
            if(nums[mid] == target){
                int[] res = new int[2];
                res[0] = mid;
                res[1] = mid;
                for(int j =mid+1;j<n;j++) if(nums[j] ==target)res[1] =j; else j=n;
                for(int j =mid-1;j>=0;j--)if(nums[j] ==target)res[0] =j; else j=-1;
                return res;
            }
            if (nums[mid]<target)  l = mid+1;
            else r = mid-1;
        }
        return new int[2]{-1,-1};
    }
}