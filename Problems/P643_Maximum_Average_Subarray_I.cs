namespace Problems;

public class P643_Maximum_Average_Subarray_I
{
    /// <summary>
    /// Finds the maximum average of any contiguous subarray of length <paramref name="k"/> within the given array.
    /// </summary>
    /// <remarks>This method uses a sliding window approach to efficiently calculate the maximum average. The
    /// result is computed as a double to ensure precision.</remarks>
    /// <param name="nums">An array of integers representing the input data.</param>
    /// <param name="k">The length of the contiguous subarray for which the maximum average is calculated. Must be greater than 0 and
    /// less than or equal to the length of <paramref name="nums"/>.</param>
    /// <returns>The maximum average of any contiguous subarray of length <paramref name="k"/>.</returns>
    public static double FindMaxAverage(int[] nums, int k)
    {
        int n = nums.Length;

        double curr = 0;

        for (int i = 0; i < k; i++)
        {
            curr += nums[i];
        }

        double ans = curr;

        for (int i = k; i < n; i++)
        {
            curr += nums[i] - nums[i - k];
            ans = Math.Max(ans, curr);
        }

        return ans / k;
    }
}