namespace Algorithms_Practice.Problems.Strings.Medium;

public class Prob01
{
    /// <summary>
    ///     https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string IsValid(string input)
    {
        //Count the number of appearance for each character
        IDictionary<char, int> list = new Dictionary<char, int>();

        foreach (var s in input)
            if (list.ContainsKey(s))
                list[s]++;
            else
                list.Add(s, 1);

        var max = 0;
        var min = int.MaxValue;
        var maxCount = new List<int>();
        var minCount = new List<int>();

        foreach (var item in list)
        {
            if (list[item.Key] > max)
                max = list[item.Key];

            if (list[item.Key] < min)
                min = list[item.Key];
        }

        if (min == max)
            return min == 1 ? "YES" : "NO";

        foreach (var item in list)
        {
            if (list[item.Key] == max)
                maxCount.Add(item.Key);

            if (list[item.Key] == min)
                minCount.Add(item.Key);
        }

        if (maxCount.Count == list.Count - 1 && min == 1)
            return "YES";

        if (minCount.Count == list.Count - 1 && max - min == 1)
            return "YES";
        return "NO";
    }
}