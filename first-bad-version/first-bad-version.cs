/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(long n) {
        long l =1;
        long r = n;
        long mid =1;
        while(l<r){
            mid = (l+r)/2;
            if(IsBadVersion((int)mid)){
                if(!IsBadVersion((int)mid-1)) return (int)mid;
                r = mid-1;
            }
            else{
                l = mid+1;
            }
            if (r==l)
                return (int)r;
        }
        return (int)mid;
    }
}