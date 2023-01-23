public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int firstN = nums1.Length;
        List<int> res = new List<int>();
        for(int i=0;i<nums2.Length;i++){
            int repateSecondArray = 0;
            int toSearch = nums2[i];
            Console.Write($"now check{toSearch}");
            while(nums2[i] == toSearch){
                i++;
                repateSecondArray++;
                if(i == nums2.Length) break;
            }
            i--;
            Console.WriteLine($"in second   repated {repateSecondArray}");
            int repateFirstArray = Search(nums1,toSearch,0,firstN-1);
            Console.WriteLine($"and in first repated {repateFirstArray}");
            for(int j=0;j<Math.Min(repateSecondArray,repateFirstArray);j++){
                res.Add(toSearch);
            }
            
        }
        return res.ToArray();
    }
    int Search(int[] arr,int target,int l ,int r){
        Console.WriteLine($" l = {l} r = {r}");
        if(r<l) return 0;
        int mid = l + (r-l)/2;
        if( arr[mid]== target){
           // Console.WriteLine($"found Targte{target} at {mid}");
            int count =1;
            int p =mid-1;
            while(p>=0 &&arr[p] == target){count++ ; p--;}
            p = mid+1;
            while(p<arr.Length &&arr[p] ==target){count++;p++;}
            return count;
        }
        if (arr[mid] < target){
            l = mid+1;
                
        }
        else{
            r = mid-1;
        }
        return Search(arr,target,l,r);
        
    }
}