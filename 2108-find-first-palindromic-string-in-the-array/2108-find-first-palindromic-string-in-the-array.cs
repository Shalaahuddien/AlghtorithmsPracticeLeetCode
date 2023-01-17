public class Solution {
public string FirstPalindrome(string[] words) {
         string pal = "";
            string elemet = "";
            for (int i = 0; i < words.Length; i++)
            {
                for (int z = words[i].Length-1; z>=0; z--)
                {
                    elemet = words[i];
                    pal += elemet[z];
                }
                if (pal == words[i])
                {
                    return pal;
                }
                pal = "";
            }
            return "";
    }
}