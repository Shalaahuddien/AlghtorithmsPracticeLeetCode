public class Solution {
    public int Search(int[] nums, int target) {
        int BinarrySearch(int l ,int r){
            if(r<l) return -1;
            int mid = (l+r)/2;
            if(nums[mid] == target) return mid;
            if(nums[mid]< target) return BinarrySearch(mid+1,r);
            else return BinarrySearch(l,mid-1);
        }    
        return BinarrySearch(0,nums.Length-1);
    }
    
}