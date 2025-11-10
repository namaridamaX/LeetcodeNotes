using System;
using System.Text;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1) return s;

        // 1) 前処理: "^#a#b#c#$" のように変換（^ と $ は番兵）
        string t = PreProcess(s);

        int n = t.Length;
        int[] p = new int[n]; // p[i] は t 上での回文半径
        int center = 0, right = 0; // 直近で最も右に届く回文の中心と右端

        // 2) 半径配列を O(n) で求める
        for (int i = 1; i < n - 1; i++)
        {
            int mirror = 2 * center - i; // i の鏡位置

            if (right > i)
                p[i] = Math.Min(right - i, p[mirror]);

            // 番兵のおかげで境界チェック不要
            while (t[i + 1 + p[i]] == t[i - 1 - p[i]])
                p[i]++;

            // 右端を更新
            if (i + p[i] > right)
            {
                center = i;
                right = i + p[i];
            }
        }

        // 3) 最大半径から元文字列の開始位置と長さを復元
        int maxLen = 0, centerIndex = 0;
        for (int i = 1; i < n - 1; i++)
        {
            if (p[i] > maxLen)
            {
                maxLen = p[i];
                centerIndex = i;
            }
        }

        int start = (centerIndex - maxLen) / 2; // 変換前インデックスに戻す
        return s.Substring(start, maxLen);
    }

    private string PreProcess(string s)
    {
        var sb = new StringBuilder("^");
        foreach (var c in s)
        {
            sb.Append('#');
            sb.Append(c);
        }
        sb.Append("#$");
        return sb.ToString();
    }
}
