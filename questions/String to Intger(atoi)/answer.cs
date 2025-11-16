public class Solution {
    public int MyAtoi(string s) {
        var wordList = new List<char>();
        long longResult = 0;
        int result = 0;
        var minusFlag = false;
        var firstFlag = false;


        for (int i = 0; i < s.Length; i++)
        {
            char word = s[i];
            if (word == ' ' && !firstFlag)
            {
                continue;
            }

            if (word == '-' && !firstFlag)
            {
                minusFlag = true;
                firstFlag = true;
                continue;
            }
            else if (word == '+' && !firstFlag)
            {
                minusFlag = false;
                firstFlag = true;
                continue;
            }

            if (int.TryParse(word.ToString(), out _))
            {
                wordList.Add(word);
                firstFlag = true;
            }
            else
            {
                break;
            }
        }

        var stringWordList = new string(wordList.ToArray());
        long.TryParse(stringWordList, out longResult);
        if (minusFlag)
        {
            longResult = longResult * -1;
        }

        if (longResult < int.MinValue)
        {
            return int.MinValue;
        }
        else if (longResult > int.MaxValue)
        {
            return int.MaxValue;
        }

        return (int)longResult;
    }
}