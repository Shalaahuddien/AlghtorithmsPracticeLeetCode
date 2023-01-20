public class Solution {
    public string ReversePrefix(string word, char ch) {
        char[] res = word.ToCharArray();
        for(int i=0;i<word.Length;i++){
            if(res[i] == ch){
                string reversed = Reverse(res[0..(i+1)]);
                for(int j=0;j<=i;j++)
                    res[j] = reversed[j];
                break;
            }
        }
        return new String(res);
    }
    string Reverse(char[] arr){
        int n = arr.Length;
        Console.WriteLine(new String(arr));
        for(int i=0;i<n/2;i++){
            (arr[i],arr[n-i-1])=(arr[n-i-1],arr[i]);
        }
        Console.WriteLine(new String(arr));
        return new String(arr);
    }
}

