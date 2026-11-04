public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        if(numBottles<numExchange) return numBottles;
        int empty = numBottles;//5
        while(empty>=numExchange)//5>3
        {
            int bottleEx = empty / numExchange; //1
            int left= empty % numExchange;//2
            numBottles+=bottleEx;//6;
            empty= left+bottleEx;//3;
        }
        return numBottles;

    }
}
