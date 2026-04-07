public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
        var hashset = new HashSet<int>(nums);
        int max=0;
        foreach(var num in hashset){
            if(!hashset.Contains(num-1)){
                int curr=num;
                int len=1;
                while(hashset.Contains(curr+1)){
                    curr++;
                    len++;
                }
                max =Math.Max(len,max);
            }
        }
        return max;
    }
}
