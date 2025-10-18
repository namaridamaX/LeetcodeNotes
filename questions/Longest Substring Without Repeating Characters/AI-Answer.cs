public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var last = new Dictionary<char, int>(); // 文字 -> 直近位置+1
        int left = 0, ans = 0;

        for (int r = 0; r < s.Length; r++) {
            char c = s[r];
            if (last.TryGetValue(c, out int prev)) {
                // 左端を、重複位置の次(=prev)までジャンプ（戻さないようにmax）
                left = Math.Max(left, prev);
            }
            ans = Math.Max(ans, r - left + 1);
            last[c] = r + 1; // 位置+1を保存
        }
        return ans;
    }
}


//別解
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] last = new int[256]; // 0で未出、出たら位置+1
        int left = 0, ans = 0;

        for (int r = 0; r < s.Length; r++) {
            int idx = last[(byte)s[r]];
            if (idx > 0) left = Math.Max(left, idx);
            ans = Math.Max(ans, r - left + 1);
            last[(byte)s[r]] = r + 1;
        }
        return ans;
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        int left = 0, ans = 0;

        for (int r = 0; r < s.Length; r++) {
            while (set.Contains(s[r])) {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[r]);
            ans = Math.Max(ans, r - left + 1);
        }
        return ans;
    }
}