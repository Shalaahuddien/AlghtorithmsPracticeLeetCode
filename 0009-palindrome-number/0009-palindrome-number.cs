public class Solution {
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        int n = str.Length;
        for(int i=0;i<n/2;i++){
            if(str[i] != str[n-i-1])
            return false;
        }
        return true;
    }
}