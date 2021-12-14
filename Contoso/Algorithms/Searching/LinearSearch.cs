namespace Contoso.Algorithms.Searching;
public class LinearSearch
{
    public static long search(long[] arr, long x)
    {
        long n = arr.Length;
        for (long i = 0; i < n; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }
}