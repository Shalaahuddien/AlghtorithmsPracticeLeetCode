public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int diff =0;
        char c1 ='a';
        char c2 ='a';
        for(int i=0;i<s2.Length;i++)
        {
            Console.WriteLine($"check s1 = {s1[i]} s2= {s2[i]}");
            if(s1[i]==s2[i]) continue;
            diff+=1;
            if(diff==1) {
                c1 = s1[i]; 
                c2 = s2[i];
            }
            if(diff==2){
                Console.WriteLine($"c1 = {c1} c2= {c2}");
                if(c1!=s2[i]) return false;
                if(c2!=s1[i]) return false;
            }
        }
        Console.WriteLine("here");
        if (diff == 2 || diff==0) return true;
        return false;
    }
}