/*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */

public class Solution {
    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z) {
        IList<IList<int>> res = new List<IList<int>>();
        for(int x=1;x<=1000;x++){
            int l =1;
            int r=1000;
            //Console.WriteLine($"x = {x}");
            while(l<=r){
                int mid = (l+r)/2;
               // Console.WriteLine($"L = {l}, R = {r} ,Mid = {mid}");
                List<int> pair = new List<int>(){x,mid};
                int funcRes = customfunction.f(x,mid);
                if(funcRes==z){
                    res.Add(pair);
                   // Console.WriteLine($"pair res = {x},{mid}");
                    break;
                }
                else if (funcRes>z){
                    r = mid-1;
                }
                else {
                    l = mid+1;
                }
            }

        }
        return res;
    }
}