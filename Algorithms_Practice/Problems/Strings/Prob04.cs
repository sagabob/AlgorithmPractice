namespace Algorithms_Practice.Problems.Strings;

public class Prob4
{
    /// <summary>
    ///     https://www.hackerrank.com/challenges/day-of-the-programmer/problem
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public static string DayOfProgrammer(int year)
    {
        var ddMmYyyy = year == 1918 ? "26.09." + year
            : year % 4 == 0 && year < 1918 ? "12.09." + year
            : year > 1918 && year % 400 == 0 ? "12.09." + year
            : year > 1918 && year % 4 == 0 && year % 100 != 0 ? "12.09." + year : "13.09." + year;
        return ddMmYyyy;
    }
}