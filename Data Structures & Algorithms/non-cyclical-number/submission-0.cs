public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new HashSet<int>();
        
        while(true){
            int temp=0;
            while (n>0){
            int carry = n%10;
          //  Console.WriteLine(carry);
            n/=10;
         //   Console.WriteLine(n);
            temp+=carry*carry;
         //   Console.WriteLine(temp);
        }
        n=temp;

        if(temp==1) return true;
        if(seen.Contains(temp)){
            return false;
        }else{
            seen.Add(temp);
        }
        }
    }


}
