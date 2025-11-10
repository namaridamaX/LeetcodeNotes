public class Solution {
    public int Reverse(int x) {

        var minusFlag = false;
        var resultInt = 0;

        if (x == 0)
        {
            return resultInt;
        }

        if(x > int.MaxValue || x < int.MinValue)
        {
            return resultInt;
        }

        if (x < 0)
        {
            x *= -1;
            minusFlag = true;
        }

        var stringNumber = x.ToString();
        var resultList = new List<char>();

        for (int i = stringNumber.Length - 1; i >= 0; i--)
        {
            resultList.Add(stringNumber[i]);
        }

        var resultString = new string(resultList.ToArray());
        int.TryParse(resultString, out resultInt);

        if (minusFlag)
        {
            resultInt *= -1;
        }

        return resultInt;
    }
}