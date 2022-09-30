namespace Algorithms_Practice.Problems.DP.Medium;

public static class Prob01
{
    public static string LongestPalindrome(string s)
    {
        var length = s.Length;

        if (length == 1)
            return s;

        var arr = new int[length, length];

        var max = 0;
        var start = -1;
        var end = -1;
        for (var i = 0; i < length; i++)
        for (var j = i; j >= 0; j--)
        {
            var currentString = s.Substring(0, i + 1);
            var sub = currentString.Substring(i - j, i - j + 1);

            if (!IsPalindromic(sub)) continue;
            arr[i - j, i] = 1;

            if (max >= i - j + 1) continue;
            max = i - j + 1;
            end = i + 1;
            start = j;
        }

        return s.Substring(start, end);
    }

    private static bool IsPalindromic(string s)
    {
        return s.Equals(s.Reverse());
    }
}