public class Solution {
    public int HammingWeight(uint n) => (from bit in Convert.ToString(n,2)
                                        where bit=='1'
                                        select bit).Count();
}