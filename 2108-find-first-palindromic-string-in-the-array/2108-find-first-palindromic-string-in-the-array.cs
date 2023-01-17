public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(string s in words)
            if(isPalindomic(s))
                return s;
        return "";
    }
    bool isPalindomic(string s){
        int n =s.Length;
        for(int i=0;i<(1+n)/2;i++){
            if(s[i] != s[n-i-1]) return false;
        }
        return true;
    }
}