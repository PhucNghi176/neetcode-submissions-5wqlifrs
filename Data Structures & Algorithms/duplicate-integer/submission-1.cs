public class Solution {
    public bool hasDuplicate(int[] nums) {
       var dictionary = new Dictionary<int, int>();
    foreach (var item in nums)
    {
        if (!dictionary.TryAdd(item, 0))
            return true;
    }

    return false;
    }
}