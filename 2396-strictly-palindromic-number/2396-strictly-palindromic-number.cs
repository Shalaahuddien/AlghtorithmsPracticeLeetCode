public class Solution {
    public bool IsStrictlyPalindromic(int n) {
        for(int i=2;i<=n-2;i++){
            string num = Convert.ToString(n,i);
           // Console.WriteLine($"base = {i} , numb ="+num);
            if( !IsPalindrome(num));
               return false;
        }
        return true;
    }
    public bool IsPalindrome(string str) {
       // string str = x.ToString();
        int n = str.Length;
        for(int i=0;i<n/2;i++){
            if(str[i] != str[n-i-1])
            return false;
        }
        return true;
    }
}