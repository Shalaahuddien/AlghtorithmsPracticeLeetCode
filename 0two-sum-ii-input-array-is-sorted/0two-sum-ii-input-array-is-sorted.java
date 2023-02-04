class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int left = 0, right = numbers.length - 1;
        while (left < right) {
            int curr_sum = numbers[left] + numbers[right];
            if (curr_sum == target) {
                return new int[] {left + 1, right + 1};
            } else if (curr_sum < target) {
                left++;
            } else {
                right--;
            }
        }
        return new int[] {};
    }
}