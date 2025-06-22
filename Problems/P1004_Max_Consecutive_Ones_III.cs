namespace Problems
{
    /// <summary>
    /// LeetCode problem 1004. Max Consecutive Ones III. Find the longest subarray with at most <c>k</c> zeros.
    /// </summary>
    /// <remarks>
    /// Category: Sliding Window
    /// LeetCode link: https://leetcode.com/problems/max-consecutive-ones-iii/
    /// </remarks>
    public class P1004_Max_Consecutive_Ones_III
    {
        /// <summary>
        /// Finds the maximum length of a contiguous subarray containing ones,  where up to <paramref name="k"/> zeros
        /// can be flipped to ones.
        /// </summary>
        /// <remarks>This method uses a sliding window approach to efficiently calculate the result. The
        /// input array <paramref name="nums"/> must contain only 0s and 1s.
        /// <para>Time complexity: O(n).</para>
        /// <para>Space complexity: O(1).</para></remarks>
        /// <param name="nums">An array of integers consisting of 0s and 1s.</param>
        /// <param name="k">The maximum number of zeros that can be flipped to ones.</param>
        /// <returns>The length of the longest contiguous subarray containing ones after flipping  up to <paramref name="k"/>
        /// zeros.</returns>
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0, right = 0, maxLength = 0, zeroCount = 0;
            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    zeroCount++;
                }
                while (zeroCount > k)
                {
                    if (nums[left] == 0)
                    {
                        zeroCount--;
                    }
                    left++;
                }
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
            return maxLength;
        }
    }
}