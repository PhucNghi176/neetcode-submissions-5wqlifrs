public class Solution {
    public int[] CountBits(int n) {
        int[] res = new int[n+1];
        for(int i =1;i<=n;i++){
            int num =i;
            while(num!=0){
               num&= (num-1);
               res[i]++;
            }
           

        }
        return res;
    }
}
