public class Solution {
    public int FindPeakElement(int[] nums) {
        List<int> numbers = nums.ToList();
        numbers.Add(int.MinValue);
        numbers.Insert(0,int.MinValue);
        bool IsPeak(int index)=> numbers[index]>numbers[index+1]&& numbers[index]> numbers[index-1];
        
        int n =numbers.Count;
        for(int i=1;i<n-1;i++){
            if(IsPeak(i)) return i-1;
        }
        return 0;

        
    }
    
}