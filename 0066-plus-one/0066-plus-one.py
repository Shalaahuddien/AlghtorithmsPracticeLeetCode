class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        n = len(digits)
        lastIndex = n-1
        for i in range(n):
            if digits[lastIndex-i] == 9:
                digits[lastIndex-i] =0
            else:
                digits[lastIndex-i] +=1
                return digits
        digits.insert(0,1)
        return digits
       
        