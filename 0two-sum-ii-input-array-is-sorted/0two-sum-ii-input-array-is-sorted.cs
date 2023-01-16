public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        int l = 0;
        int r = n-1;
        while(l<r){
            int sum = numbers[l] + numbers[r];
            if(sum== target) return new int[2]{l+1,r+1};
            if(sum<target) l+=1;
            else r-=1;
        }
        return new int[2];
    }
}