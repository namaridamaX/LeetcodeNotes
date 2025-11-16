public class Solution
{
    public int MyAtoi(string s)
    {
        int n = s.Length;
        int i = 0;

        // 先頭の空白をスキップ
        while (i < n && s[i] == ' ') i++;
        if (i == n) return 0;

        //符号を1回だけ読む
        int sign = 1;
        if (s[i] == '+' || s[i] == '-')
        {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        // 数字を読みながら、桁ごとにオーバーフロー判定して積み上げ
        int value = 0;
        while (i < n && char.IsDigit(s[i]))
        {
            int d = s[i] - '0';

            // オーバーフローを事前に検知してクランプ
            if (sign == 1)
            {
                if (value > int.MaxValue / 10 || (value == int.MaxValue / 10 && d > 7))
                    return int.MaxValue;
            }
            else
            {
                if (value == int.MaxValue / 10 && d == 8)
                    return int.MinValue;
                    
                if (value > int.MaxValue / 10 || (value == int.MaxValue / 10 && d > 8))
                    return int.MinValue;
            }

            value = value * 10 + d;
            i++;
        }

        return sign * value;
    }
}