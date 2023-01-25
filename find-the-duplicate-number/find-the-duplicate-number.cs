public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> founded = new();
        for(int i=0;i<nums.Length;i++){
            if(founded.Contains(nums[i]))
                return nums[i];
            founded.Add(nums[i]);
        }
        return nums[0];
    }
}