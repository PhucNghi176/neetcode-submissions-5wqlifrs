public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
        var list = new SortedDictionary<int, int>();
            foreach (var n in nums)
            {
                if (!list.ContainsKey(n))
                {
                    list.Add(n, 0);
                }

            }
            int max = 1;
            int first = list.First().Key;
            int temp = 1;
            foreach (var item in list.Keys)
            {
                if (first + 1 == item)
                {
                    temp++;
                    if (temp > max) max = temp;
                }
                else
                {
                    temp = 1;
                }
                first = item;
               

            }
            return max; 
    }
}
