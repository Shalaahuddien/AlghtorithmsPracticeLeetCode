public class Solution {
    public int[] ShortestToChar(string s, char c) {
int n= s.Length;
int pos=-10000;
int[] res=new int[n];
 for(int src=0;src<n;src++){
   if(s[src]==c){
     for(int i=pos<0?0:pos;i<=src;i++)

      res[i] = Math.Min(src-i,i-pos);


     pos=src;
   }
   else if(src==n-1){
       for(int i=pos;i<n;i++){
           res[i]= i-pos;
       }
   }
 }
return res;
}
}