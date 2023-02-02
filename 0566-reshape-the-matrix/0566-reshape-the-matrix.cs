public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int n = mat.Length;
        int m = mat[0].Length;
        if (r*c != n*m) return mat;
        int[] items = new int[r*c];
        for(int i=0;i<n;i++)
            for(int j=0;j<m;j++)
                items[m*i + j] = mat[i][j];
        foreach(int x in items) Console.Write($" {x} ");
        int[][] res = new int[r][];
        for(int i=0;i<r;i++){
            int[] row = new int[c];
            for(int j=0;j<c;j++)
                row[j] = items[c*i+j];
            res[i] = row;
        }

        return res;
    }
}