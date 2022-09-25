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

    public static int[] Solution(int[] balances, string[] requests)
    {
        for (var i = 0; i < requests.Length; i++)
        {
            var statement = requests[i];

            var parts = statement.Split(" ");

            var command = parts[0];
            int amount;
            int balanceInt;

            switch (command)
            {
                case "withdraw":
                    amount = int.Parse(parts[2]);
                    balanceInt = int.Parse(parts[1]) - 1;

                    if (balanceInt >= 0 && balanceInt < balances.Length && balances[balanceInt] - amount >= 0)
                        balances[balanceInt] = balances[balanceInt] - amount;
                    else
                        return new[] { -(i + 1) };
                    break;

                case "deposit":
                    amount = int.Parse(parts[2]);
                    balanceInt = int.Parse(parts[1]) - 1;
                    balances[balanceInt] = balances[balanceInt] + amount;
                    break;


                case "transfer":

                    amount = int.Parse(parts[3]);

                    balanceInt = int.Parse(parts[1]) - 1;
                    var balanceEnd = int.Parse(parts[2]) - 1;

                    if (balanceInt >= 0 && balanceInt < balances.Length && balances[balanceInt] - amount >= 0 &&
                        balanceEnd >= 0 && balanceEnd < balances.Length)
                    {
                        balances[balanceInt] = balances[balanceInt] - amount;
                        balances[balanceEnd] = balances[balanceEnd] + amount;
                    }

                    else
                        return new[] { -(i + 1) };

                    break;
            }
        }

        return balances;
    }
}