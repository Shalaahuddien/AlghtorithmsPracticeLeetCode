public class Solution {
    public int CountOdds(int low, int high) {
        if ((low%2==1) && (high%2==1)) return  1+(high-low)/2;
        return (high-low+1)/2;
    }
}
