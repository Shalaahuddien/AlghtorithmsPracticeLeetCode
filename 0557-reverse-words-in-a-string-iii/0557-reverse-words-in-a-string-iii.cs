class Solution {
    public string ReverseWords(string s) {
        string res ="";
        string word ="";
        for(int i=0;i<s.Length;i++){
            if (s[i] == ' '){
               // Console.WriteLine(word);
                res+= reverse(word);
                res+=' ';
                word ="";
            }
            else if(i == s.Length-1){
                 word+=s[i];
                //Console.WriteLine(word);
                res += reverse(word);
            }
            else{
                //Console.WriteLine(s[i]);
                word+=s[i];
            }
        }
        return res;
    }
    public string reverse(string ss){
        int n = ss.Length;
        char[] res = ss.ToCharArray();
        for(int i=0;i<n/2;i++){
            char temp = res[i];
            res[i] = res[n-i-1];
            res[n-i-1] = temp;
        }
        return new string(res);
    }
};