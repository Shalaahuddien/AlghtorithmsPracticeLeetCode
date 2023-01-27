public class Solution {
    public double Average(int[] salary) {
        int min = salary[0];
        int max = salary[0];
        int sum = salary[0];
        int n = salary.Length;
        for(int i=1;i<n;i++){
            sum+= salary[i];
            max = Math.Max(salary[i],max);
            min = Math.Min(salary[i],min);
        }
        double res = (double)(sum-min-max)/(n-2);
        return res;
    }
}