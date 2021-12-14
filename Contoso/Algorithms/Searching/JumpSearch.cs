namespace Contoso.Algorithms.Searching;
public class JumpSearch
{
    public static long search(long[] arr, long x)
    {
        long n = arr.Length;

        // Finding block size to be jumped
        long step = (long)Math.Floor(Math.Sqrt(n));

        // Finding the block where element is
        // present (if it is present)
        long prev = 0;
        while (arr[Math.Min(step, n) - 1] < x)
        {
            prev = step;
            step += (long)Math.Floor(Math.Sqrt(n));
            if (prev >= n)
                return -1;
        }

        // Doing a linear search for x in block
        // beginning with prev.
        while (arr[prev] < x)
        {
            prev++;

            // If we reached next block or end of
            // array, element is not present.
            if (prev == Math.Min(step, n))
                return -1;
        }

        // If element is found
        if (arr[prev] == x)
            return prev;

        return -1;
    }

}