namespace Algorithms_Practice.Core.Sorting;

public static class QuickSort
{
    /// <summary>
    ///     This is the classic quick sort
    ///     https://www.geeksforgeeks.org/quick-sort/
    ///     https://towardsdatascience.com/an-overview-of-quicksort-algorithm-b9144e314a72
    ///     https://medium.com/karuna-sehgal/a-quick-explanation-of-quick-sort-7d8e2563629b
    /// </summary>
    /// <param name="arr"></param>
    public static int[] DoSorting(int[] arr)
    {
        var length = arr.Length;

        if (length is 1 or 0)
            return arr;

        var left = new List<int>();
        var right = new List<int>();

        var pivot = arr[0];

        for (var i = 1; i < length; i++)
            if (arr[i] < pivot)
                left.Add(arr[i]);
            else
                right.Add(arr[i]);

        left.Add(pivot);

        var sortedLeft = DoSorting(left.ToArray());
        var sortedRight = DoSorting(right.ToArray());

        var sortedArray = sortedLeft.Concat(sortedRight).ToArray();

        return sortedArray;
    }
}