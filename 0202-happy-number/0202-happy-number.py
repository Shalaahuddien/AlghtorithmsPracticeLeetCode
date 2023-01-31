class Solution:
    def isHappy(self, n: int) -> bool:
        def convert(x):
            res= 0
            while x>0:
                digit = x%10;
                x=x//10
                res += digit*digit
            return res
        oldNumbers =set([])
        nowNumber = convert(n)
        while(nowNumber!=1):
            if ( nowNumber in oldNumbers):
                return False
            oldNumbers.add(nowNumber)
            nowNumber = convert(nowNumber)
        return True;
