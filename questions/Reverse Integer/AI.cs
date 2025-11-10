public class Solution {
    public int Reverse(int x) {
        long result = 0; // longでオーバーフロー回避
        while (x != 0) {
            result = result * 10 + x % 10;
            x /= 10;
        }

        if (result < int.MinValue || result > int.MaxValue)
            return 0;

        return (int)result;
    }
}
