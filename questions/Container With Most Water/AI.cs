public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int h = Math.Min(height[left], height[right]); // 高さは小さい方
            int w = right - left;                          // 幅はインデックス差
            int area = h * w;

            if (area > maxArea)
            {
                maxArea = area;
            }

            // 小さい方を動かす（大きい方を動かしても高さは上がらないので意味がない）
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
