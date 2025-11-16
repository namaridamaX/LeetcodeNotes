public class Solution
{
    public bool IsPalindrome(int x)
    {

        if (x < 0) return false;

        if (x < 10) return true;

        if (x % 10) return false;

        int reverseHalf = 0;

        while (x > reverseHalf)
        {
            reverseHalf = reverseHalf * 10 + x % 10;
            x /= 10;
        }

        return (x == reverseHalf) || (x == reverseHalf / 10);
    }
}