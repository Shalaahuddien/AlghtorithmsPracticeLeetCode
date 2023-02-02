public class Solution {
    public int DiagonalSum(int[][] mat) {
        int n =mat.Length;
        int m =mat[0].Length;
        int sum=0;
        for(int i=0;i<n;i++)
            for(int j=0;j<m;j++)
                if(i==j || i+j==n-1)
                    sum+=mat[i][j];
        return sum;
    }
}