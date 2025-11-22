public class Solution {
    public int RomanToInt(string s) {
        var result = 0;

        if (s.Contains("MMM"))
        {
            result += 3000;
        }
        else if (s.Contains("MM"))
        {
            result += 2000;
        }
        else if (s.Contains("M"))
        {
            result += 1000;
        }

        if (s.Contains("CM"))
        {
            result += 900;
        }

        if (s.Contains("DC"))
        {
            result += 400;
        }
        else if (s.Contains("D"))
        {
            result += 500;
        }

        if (s.Contains("CCC"))
        {
            result += 300;
        }
        else if (s.Contains("CC"))
        {
            result += 200;
        }
        else if (s.Contains("C"))
        {
            result += 100;
        }

        if (s.Contains("XC"))
        {
            result += 90;
        }

        if (s.Contains("XL"))
        {
            result += 40;
        }
        else if (s.Contains("L"))
        {
            result += 50;
        }

        if (s.Contains("XXX"))
        {
            result += 30;
        }
        else if (s.Contains("XX"))
        {
            result += 20;
        }
        else if (s.Contains("X"))
        {
            result += 10;
        }

        if (s.Contains("IV"))
        {
            result += 4;
        }
        else if (s.Contains("V"))
        {
            result += 5;
        }

        if (s.Contains("III"))
        {
            result += 3;
        }
        else if (s.Contains("II"))
        {
            result +=2;
        }
        else if(s.Contains("I"))
        {
            result +=1;
        }

        return result;
    }
}