def plus_one(digits)
    (digits.length - 1).downto(0) do |i|
        if digits[i] == 9
            digits[i] = 0
        else
            digits[i] += 1
            return digits
        end
    end
    [1] + digits
end