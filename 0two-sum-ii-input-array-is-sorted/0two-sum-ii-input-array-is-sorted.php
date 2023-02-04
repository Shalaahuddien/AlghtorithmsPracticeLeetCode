<?php

class Solution {

    /**
     * @param Integer[] $numbers
     * @param Integer $target
     * @return Integer[]
     */
    function twoSum($numbers, $target) {
    $left = 0;
    $right = count($numbers) - 1;
    while ($left < $right) {
        $curr_sum = $numbers[$left] + $numbers[$right];
        if ($curr_sum == $target) {
            return [$left + 1, $right + 1];
        } elseif ($curr_sum < $target) {
            $left++;
        } else {
            $right--;
        }
    }
    return [];
}

}