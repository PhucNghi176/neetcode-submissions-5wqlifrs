public class Solution {
    public int[] TwoSum(int[] nums, int target) {
var indices = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (indices.ContainsKey(target - nums[i]))
        {
            return new int[] { indices[target - nums[i]] ,i};
        }
        else
        {
            indices.Add(nums[i], i);
        }
    }
    return null;
    }
}
