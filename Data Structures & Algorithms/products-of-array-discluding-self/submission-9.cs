public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
 for (int i = 0; i < nums.Length; i++)
 {
     var prod = 1;
     for (int j = 0; j < nums.Length; j++)
     {
         if (j != i) prod *= nums[j];

     }
     res[i] = prod;
 }
 return res;
    }
}
