namespace Algorithms_Practice.Core.Search;

public static class BinarySearch
{
    /// <summary>
    ///     https://www.geeksforgeeks.org/binary-search/
    /// </summary>
    /// <param name="a"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static bool Execute(int[] a, int target)
    {
        var length = a.Length;

        if (length == 1)
            return a[0] == target;

        var hasResult = DoSearch(a, target, 0, a.Length - 1);

        return hasResult;
    }

    private static bool DoSearch(int[] a, int target, int low, int high)
    {
        while (true)
        {
            if (low > high) return false;

            if (low == high)
                return a[low] == target;

            var mid = (low + high) / 2;

            if (a[mid] == target) return true;

            if (a[mid] > target)
            {
                high = mid;
                continue;
            }

            low = mid + 1;
        }
    }
}