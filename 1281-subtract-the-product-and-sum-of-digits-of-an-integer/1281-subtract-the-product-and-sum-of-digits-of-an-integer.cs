public class Solution {
    public int SubtractProductAndSum(int n) {
        int p=1;
        int sum=0;
        foreach(char c in  Convert.ToString(n)){
            p*= Convert.ToInt32(c-'0');
            sum+=Convert.ToInt32(c-'0');
            Console.WriteLine($"p = {p} sum = {sum}");
        }
        return p-sum;
    }
}