public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int HigherIndex(int l ,int r ){
            if (l+1>=r){
                if(nums[r] == target) return r;
                if(nums[l] == target) return l;
                return -1;
            }
            int mid = l + (r-l)/2;
            if(nums[mid] == target&& nums[mid+1]>target&&nums[mid-1]<=target){
                return mid;
            }
            if (nums[mid]<=target) return HigherIndex(mid,r);
            return HigherIndex(l,mid);
    }
        int LowerIndex(int l ,int r ){
            int mid = l + (r-l)/2;
           // Console.WriteLine($"l = {l} r  = {r} , mid ={mid}");
            if (l+1>=r){
               // Console.WriteLine("Break l = {l} r = {r}");
                if(nums[l] == target) return l;
                if(nums[r] == target) return r;
                return -1;
            }
            if(nums[mid] == target && nums[mid+1]>=target&&nums[mid-1]<target){
           //     Console.WriteLine($"Founded in l = {l} r  = {r} , mid ={mid} {nums[mid]}, {nums[mid+1]},{nums[mid-1]}");
                return mid;
            }
            if (nums[mid]<target) return LowerIndex(mid,r);
            return LowerIndex(l,mid);
    }

        int n = nums.Length;
        if (n ==0) return new int[2]{-1,-1};
        int l =0;
        int r = n-1;
        //Console.WriteLine(LowerIndex(l,r));
        return new int[2]{LowerIndex(l,r),HigherIndex(l,r)};
    }

}