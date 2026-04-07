public class Solution {
    public bool hasDuplicate(int[] nums) {
        return nums.ToHashSet().Count!=nums.Length;
    }
}