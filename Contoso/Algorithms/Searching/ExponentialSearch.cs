namespace Contoso.Algorithms.Searching;

public class ExponentialSearch
{
    public static long search(long[] arr, long n, long x)
    {
        // If x is present at
        // first location itself
        if (arr[0] == x)
            return 0;

        // Find range for binary search
        // by repeated doubling
        long i = 1;
        while (i < n && arr[i] <= x)
            i = i * 2;

        // Call binary search for
        // the found range.
        return BinarySearch.search(arr, i / 2, Math.Min(i, n - 1), x);
    }
}