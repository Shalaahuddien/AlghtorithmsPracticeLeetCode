def two_sum(numbers, target)
    left = 0
    right = numbers.length - 1
    while left < right
        curr_sum = numbers[left] + numbers[right]
        if curr_sum == target
            return [left + 1, right + 1]
        elsif curr_sum < target
            left += 1
        else
            right -= 1
        end
    end
    []
end