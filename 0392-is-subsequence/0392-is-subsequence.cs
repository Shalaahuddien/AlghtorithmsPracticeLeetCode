public class Solution {
    public bool IsSubsequence(string s, string t) {
        int p=0;
        if (s.Length==0)return true;
        for(int i=0;i<t.Length;i++){
            if(t[i] == s[p]){
                p++;
                if(p == s.Length) return true;
            }
        }
        return false;
    }
}