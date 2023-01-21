/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        long Search(long l,long r){
            long mid = (l+r)/2;
           // Console.WriteLine($"l = {l} r = {r} mid = {mid}");
            if(guess((int)mid) == 0) return mid;
            if(guess((int)mid) == 1) return Search(mid+1,r);
            return Search(l,mid-1);
        }
        return (int)Search(0,n);
    }
}