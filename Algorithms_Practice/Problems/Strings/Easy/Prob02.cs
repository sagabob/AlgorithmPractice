namespace Algorithms_Practice.Problems.Strings.Easy;

public static class Prob02
{
    /// <summary>
    ///     https://www.hackerrank.com/challenges/strong-password/problem
    /// </summary>
    /// <param name="n"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public static int MinimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        const string numbers = "0123456789";
        const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string specialCharacters = "!@#$%^&*()-+";

        var add = 0;

        if (!HasSpecialCharacters(password, numbers))
            add++;

        if (!HasSpecialCharacters(password, lowerCase))
            add++;

        if (!HasSpecialCharacters(password, upperCase))
            add++;

        if (!HasSpecialCharacters(password, specialCharacters))
            add++;

        return n < 6 ? Math.Max(6 - n, add) : add;
    }

    private static bool HasSpecialCharacters(string s, string dicStr)
    {
        return s.Any(sub => dicStr.Contains(sub, StringComparison.CurrentCulture));
    }
}