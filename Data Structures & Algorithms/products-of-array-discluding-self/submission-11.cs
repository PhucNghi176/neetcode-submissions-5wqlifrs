public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod =1, zerocount=0;
        foreach(var n in nums){
            if(n!=0) prod *= n;
            else{
                zerocount++;
                
            }
        }

        if(zerocount >1){
            return new int[nums.Length];
        }

        int[] res = new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            if(zerocount >0){
                res[i]=(nums[i]==0? prod:0);
            }
            else{
                res[i]= prod/nums[i];
            }
        }
        return res;
    }
}
