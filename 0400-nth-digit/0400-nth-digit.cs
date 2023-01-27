public class Solution {
    long[] NumOfDigitsBefore = new long[11];
    public int FindNthDigit(int n) {
        Build();
        long l = 1;
        long r =n;
        long mid;
        while(l<r){
            mid = l + (r-l)/2;
            long before = HowDigitsBefore(mid);
            long BeforPlusDigits = before+digits(mid);
           // Console.WriteLine($"l = {l} , r = {r} mid = {mid} before = {before} + digits = {BeforPlusDigits}");
            if((before<n) &&(n<=BeforPlusDigits)){
                long diff = n-before;
                return (int)(mid.ToString()[(int)diff-1] -'0');
            }
            if(n<BeforPlusDigits)
               r = mid;
            else
               l= mid+1;
        }
        long diff2 = n-HowDigitsBefore(l);
        return (int)(l.ToString()[(int)diff2-1] -'0');
    }
    public void Build(){
        NumOfDigitsBefore[0]=0;
        NumOfDigitsBefore[1]=0;
        NumOfDigitsBefore[2]=9;
        for(long i=2;i<11;i++){
            long tenth = 9*(long)Math.Pow(10,i-2);
            long tenthByDigit = tenth*(i-1);
            NumOfDigitsBefore[i] = NumOfDigitsBefore[i-1]+tenthByDigit;
        }

    }
    public long HowDigitsBefore(long x){
        long digitNum = digits(x);
        long afterStart = (x - (long)Math.Pow(10,digitNum-1)) * digitNum;
        return NumOfDigitsBefore[digitNum]+afterStart ;
    }
    public long digits(long x)=>x.ToString().Length;
}