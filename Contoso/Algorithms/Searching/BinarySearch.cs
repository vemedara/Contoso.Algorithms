namespace Contoso.Algorithms.Searching;

public class BinarySearch
{
    public static long search(long[] arr, long l, long r, long x)
    {
        if (r >= l)
        {
            long mid = l + (r - l) / 2;

            // If the element is present at the
            // middle itself
            if (arr[mid] == x)
                return mid;

            // If element is smaller than mid, then
            // it can only be present in left subarray
            if (arr[mid] > x)
                return search(arr, l, mid - 1, x);

            // Else the element can only be present
            // in right subarray
            return search(arr, mid + 1, r, x);
        }

        // We reach here when element is not present
        // in array
        return -1;
    }
}