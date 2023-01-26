public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int n = arr.Length;
        int l=0;
        int r= n-1;
        while(l+1<r){
            int mid = l+(r-l)/2;
            if(arr[mid]>arr[mid-1]&&arr[mid]>arr[mid+1]){
                return mid;
            }
            else if(arr[mid]>arr[mid-1]) 
                l =mid;
            else
                r = mid;
        }
        return arr[(l+r)/2];
    }
}