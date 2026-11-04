public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int N = grid.Length;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0 ; i< N;i++){
            for(int j =0;j<N;j++){
                if(dict.ContainsKey(grid[i][j])){
                    dict[grid[i][j]]+=1;
                }
                else
                dict[grid[i][j]]=1;
            }
        }
        int twice=0;
        int missing=0;
        for(int i =1;i<=N*N;i++){
            int freg = dict.ContainsKey(i)? dict[i]:0;
            if(freg ==0) missing = i;
            if(freg ==2) twice =i;
        }
        return new int[]{twice,missing};
    }
}