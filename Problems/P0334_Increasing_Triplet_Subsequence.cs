namespace Problems;

/// <summary>
/// Provides functionality to determine whether an array contains an increasing triplet subsequence.
/// </summary>
/// <remarks>An increasing triplet subsequence is defined as three integers in the array, appearing in order, such
/// that <c>nums[i] < nums[j] < nums[k]</c> for indices <c>i</c>, <c>j</c>, and <c>k</c> where <c>i < j < k</c>. This
/// class includes a method that efficiently checks for the presence of such a subsequence using a linear scan with
/// constant space.</remarks>
public class P0334_Increasing_Triplet_Subsequence
{
    /// <summary>
    /// Determines whether the input array contains an increasing triplet subsequence.
    /// </summary>
    /// <remarks>An increasing triplet subsequence is defined as three integers in the array, appearing in
    /// order, such that <c>nums[i] < nums[j] < nums[k]</c> for indices <c>i</c>, <c>j</c>, and <c>k</c> where <c>i < j
    /// < k</c>. The method uses a linear scan with constant space to efficiently determine the presence of such a
    /// subsequence.</remarks>
    /// <param name="nums">An array of integers to check for an increasing triplet subsequence.</param>
    /// <returns><see langword="true"/> if there exists a subsequence of three integers in the array such that the first integer
    /// is less than the second, and the second is less than the third; otherwise, <see langword="false"/>.</returns>
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
            return false;

        int first = int.MaxValue, second = int.MaxValue;

        foreach (int num in nums)
        {
            if (num <= first)
            {
                first = num; // Update first to the smallest value
            }
            else if (num <= second)
            {
                second = num; // Update second to the second smallest value
            }
            else
            {
                // Found a number greater than both first and second
                return true; // This means we have found an increasing triplet subsequence
            }
        }

        return false; // No increasing triplet subsequence found
    }
}