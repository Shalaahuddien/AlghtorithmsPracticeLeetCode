public class Solution {
    public int MySqrt(int x) {
        long SQRT(long l, long r){
            long root = (l+r)/2;
            long sqr = root*root;
            //Console.WriteLine($"l = {l} r = {r} root = {root}");
            if(IsItRoot(l)) return l;
            if(IsItRoot(r)) return r;
            if(IsItRoot(root)) return root;
            if(sqr > x) return SQRT(l,root-1);
            return SQRT(root+1,r);
        }
        bool IsItRoot(long root){
            if(root*root<=x && (root+1)*(root+1) >x) return true;
            return false;
        }
        return (int)SQRT(0,x);
    }
}