namespace Algorithms_Practice.Problems.Strings;

public class Prob02
{
    /// <summary>
    ///     https://www.hackerrank.com/challenges/reduced-string/problem
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string SuperReducedString(string s)
    {
        var tempString = s;

        var isDone = false;

        while (!isDone)
        {
            var array = tempString.ToCharArray();
            var length = array.Length;

            var count = 0;
            for (var i = 0; i < length - 1; i++)
            {
                if (array[i] == '\0')
                    continue;

                if (array[i] == array[i + 1])
                {
                    array[i] = '\0'; /**/
                    array[i + 1] = '\0';

                    count++;
                }
            }

            if (count == 0)
                isDone = true;
            else
                tempString = string.Join("", array).Replace("\0", "");
        }

        return tempString.Length == 0 ? "Empty String" : tempString;
    }
}