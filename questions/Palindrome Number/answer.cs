public class Solution {
    public bool IsPalindrome(int x) {

        var result = 0;
        var xx = x;
        var xLength = x.ToString().Length;

        //0以下はfalse
        if (x < 0)
        {
            return false;
        }
        //10以下はtrue;
        if (x < 10)
        {
            return true;
        }

        var o = x % 10;
        if (o == 0)
        {
            return false;
        }

        for (int i = 0; i < xLength; i++)
        {
            var l = xLength - i;
            var ll = Math.Pow(10, i);
            var p = Math.Pow(10, l - 1);

            var hoge = xx / (int)p;
            xx = xx - hoge * (int)p;
            result = result + (int)ll * hoge;
        }

        if (result == x)
        {
            return true;
        }

        return false;
    }
}