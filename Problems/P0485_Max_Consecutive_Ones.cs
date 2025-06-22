namespace Problems;

/// <summary>
/// LeetCode problem 485. Max Consecutive Ones. Return the maximum number of consecutive 1s in a binary array.
/// </summary>
/// <remarks>
/// Category: Sliding Window
/// LeetCode link: https://leetcode.com/problems/max-consecutive-ones/
/// </remarks>
public class P485_Max_Consecutive_Ones
{
    /// <summary>
    /// Finds the maximum number of consecutive 1s in a binary array using a sliding window approach.
    /// </summary>
    /// <remarks>This method uses a sliding window technique to efficiently calculate the result. The input
    /// array must contain only binary values (0s and 1s).
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="nums">An array of integers containing only 0s and 1s.</param>
    /// <returns>The length of the longest subarray consisting of consecutive 1s.</returns>
    public int FindMaxConsecutiveOnesUsingWindow(int[] nums)
    {
        int subArrayLength = 0;
        int currentZeroCount = 0;
        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                currentZeroCount++;
            }
            while (currentZeroCount > 0)
            {
                if (nums[left] == 0)
                {
                    currentZeroCount--;
                }
                left++;
            }

            subArrayLength = Math.Max(subArrayLength, right - left + 1);
        }

        return subArrayLength;
    }

    /// <summary>
    /// Finds the maximum number of consecutive 1s in the specified array.
    /// </summary>
    /// <remarks>This method performs a linear scan of the array to determine the longest sequence of
    /// consecutive 1s. The input array must contain only 0s and 1s; behavior is undefined for other values.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="nums">An array of integers containing only 0s and 1s.</param>
    /// <returns>The maximum count of consecutive 1s in the array. Returns 0 if the array is empty or contains no 1s.</returns>
    public int FindMaxConsecutiveOnesLinearScan(int[] nums)
    {
        int maxCount = 0;
        int currentCount = 0;
        foreach (int num in nums)
        {
            if (num == 1)
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 0; // Reset count when a 0 is encountered
            }
        }

        return maxCount; // Return the maximum count of consecutive 1s found
    }
}