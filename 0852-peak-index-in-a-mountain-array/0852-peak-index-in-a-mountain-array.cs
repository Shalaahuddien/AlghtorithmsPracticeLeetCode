public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int n = arr.Length;
        int l=0;
        int r= n-1;
        while(l+1<r){
            int mid = l+(r-l)/2;
            if(arr[mid]>=arr[mid-1]) 
                l =mid;
            else
                r = mid;
        }
        int m = l+(r-l)/2;
        if (arr[m]>arr[l] && arr[m]>arr[r]) return m;
        else if (arr[r]>arr[l]) return r;
        return l;
    }
}