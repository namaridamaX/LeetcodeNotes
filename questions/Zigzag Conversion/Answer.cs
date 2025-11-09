using System.Text;

public class Solution {
    public string Convert(string s, int numRows)
    {
        //行数がジグザグにならない場合はそのまま返す
        if (numRows <= 1 || s.Length <= numRows) return s;

        //箱を用意
        var rows = new StringBuilder[Math.Min(numRows, s.Length)];
        for (int i = 0; i < rows.Length; i++) rows[i] = new StringBuilder();

        //初期状態の設定
        int curRow = 0; //現在の行番号
        int dir = 1; //1:　下方向, -1:　上方向

        foreach (char c in s)
        {
            rows[curRow].Append(c);

            if (curRow == 0) dir = 1;
            else if (curRow == numRows - 1) dir = -1;

            curRow += dir;
        }

        // 全行を結合して1つの文字列に
        var ans = new StringBuilder();
        foreach (var sb in rows) ans.Append(sb.ToString());
        return ans.ToString();
    }
}