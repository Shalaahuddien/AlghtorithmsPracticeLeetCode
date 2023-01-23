public class Solution {
    public int FindMin(int[] arr) {
        int l =0;
        int n=arr.Length;
        int r = n-1;
        while(l<r){
            while(l < n-1 && arr[l] == arr[l+1])l++;
            while(r>0 && arr[r] == arr[r-1])r--;
            int mid = l + (r-l)/2;
            
            if(mid==0) return Math.Min(arr[l],arr[r]);
            if(arr[mid] < arr[mid-1]) return arr[mid];
            if(arr[mid] <= arr[r])r = mid;
            else l = mid+1;
        }
        return arr[l];
    }
}