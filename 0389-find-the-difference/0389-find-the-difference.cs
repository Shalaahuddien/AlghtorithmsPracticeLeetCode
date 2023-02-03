public class Solution {
    public char FindTheDifference(string s, string t) {
        Dictionary<char,int> sChars = new();
        foreach(char c in s){
            if (!sChars.ContainsKey(c)) sChars[c] =0;
            sChars[c]+=1;
        }
        Dictionary<char,int> tChars = new();
        foreach(char c in t){
            if (!tChars.ContainsKey(c)) tChars[c] =0;
            tChars[c]+=1;
        }
        foreach(char c in t){
            if (!sChars.ContainsKey(c))return c;
            if (sChars[c] != tChars[c]){
                return c;
            }
        }
        return 'a';
    }
}