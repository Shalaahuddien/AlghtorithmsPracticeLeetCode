public class Solution {
public string ReverseOnlyLetters(string s) {
int n=s.Length;
int p1=0;
int p2=n-1;
char[] res = s.ToCharArray();
while(p1<p2){
    while(!IsLetter(s[p1])){
        p1++;
    if(p1>=p2) break;
    
    }
    while(!IsLetter(s[p2])){
        p2--;
    if(p1>=p2) break;
        
        }
    if(p1>=p2) break;
    char temp =res[p1];
    res[p1]=res[p2];
    res[p2]= temp;
    p1++;
    p2--;
    
    

    
}
    return new String(res);
        
}
bool IsLetter(char c){
    if (c>='a'&& c<='z') return true;
    if (c>='A'&& c<='Z') return true;
    return false;

    }
}
  