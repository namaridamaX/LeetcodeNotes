public class Solution {
    public string LongestPalindrome(string s)
    {
        var result = "";
        var charList = new List<char>();

        if(s.Length == 1)
        {
            result = s;
            return result;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (!charList.Contains(s[i]))
            {
                charList.Add(s[i]);
            }
            else
            {
                var num = charList.IndexOf(s[i]);
                while (num >= 0)
                {
                    var selectedList = charList.GetRange(num, i - num);
                    selectedList.Add(s[i]);
                    var selectedString = new string(selectedList.ToArray());
                    if (checkLongestPalindrome(selectedString))
                    {
                        if (result.Length < selectedString.Length)
                        {
                            result = selectedString;
                        }
                    }

                    num = charList.IndexOf(s[i], num + 1);
                }

                charList.Add(s[i]);
            }
        }

        if (string.IsNullOrWhiteSpace(result))
        {
            result = s[0].ToString();
        }

        return result;
    }
    
    private bool checkLongestPalindrome(string s)
    {
        var lastIndex = s.Length - 1;
        for (int i = 0; i < s.Length; i++)
        {
            var checkIndex1 = i;
            var checkIndex2 = lastIndex - i;

            if (checkIndex1 == checkIndex2)
            {
                return true;
            }
            else if (checkIndex1 > checkIndex2)
            {
                return true;
            }

            if (s[checkIndex1] != s[checkIndex2])
            {
                return false;
            }
        }

        return true;
    }
}