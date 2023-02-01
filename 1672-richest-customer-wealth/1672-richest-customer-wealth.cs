using System;

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int n = accounts.Length;
        int m = accounts[0].Length;
        int max =0;
        int sum;
        for(int i=0;i<n;i++){
            sum=0;
            for(int j=0;j<m;j++) sum+=accounts[i][j];
            max = Math.Max(sum,max);
        }
        return max;
    }
}