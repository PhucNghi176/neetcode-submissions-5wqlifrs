public class Solution {
    public int[] DailyTemperatures(int[] tm) {
        var list = new int[tm.Length];
        for(int i =0;i<tm.Length;i++){
            int c =0;
            for(int j = i+1;j<tm.Length;j++){
                Console.WriteLine($"{tm[i]} {tm[j]}");
                if(tm[i]<tm[j]){
                    c+=1;
                    list[i]=c;
                    break;
                }
                else
                c++;
            }
        }
        return list;
    }
}
