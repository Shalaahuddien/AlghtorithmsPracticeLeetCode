public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int n = image.Length;
        for(int k=0;k<n;k++){
            for(int i=0;i<(n+1)/2;i++){
                //Console.WriteLine($" i= {i} k= {k}");
                int temp = image[k][i];
                image[k][i] = image[k][n-1-i];
                image[k][i]= image[k][i]==0? 1:0;
                image[k][n-1-i] = temp;
                image[k][n-1-i]= image[k][n-1-i]==0? 1:0;
                //foreach(int v in image[k]) Console.WriteLine(v);
            }
        }
        return image;
    }
}