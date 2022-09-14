namespace Algorithms_Practice.Problems.Strings;

public static class Prob04Medium
{
    public static int LengthOfLongestSubstring(string s)
    {
        var length = s.Length;

        if (length == 1)
            return 1;
        var maxLength = 0;
        var totalMax = 0;
        var set = new HashSet<char>();

        for (var i = 0; i < length; i++)
        {
            set.Clear();
            for (var j = i; j < length; j++)
            {
                if (set.Count == 0)
                {
                    set.Add(s[j]);
                    maxLength = 1;
                }
                else
                {
                    if (set.Contains(s[j]))
                    {
                        set.Clear();
                        set.Add(s[j]);
                        maxLength = 1;
                    }
                    else
                    {
                        set.Add(s[j]);
                        maxLength++;
                    }
                }

                if (maxLength > totalMax)
                    totalMax = maxLength;
            }
        }

        return totalMax;
    }
}