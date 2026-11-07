
public class Solution {
    public uint ReverseBits(uint n) {
        uint res = 0;

        for (int i = 0; i < 32; i++) {
            uint temp = n & 1;
            res = (res << 1) | temp;
            n >>= 1;
        }

        return res;
    }
}
