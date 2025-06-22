namespace Problems;

public class P1480_Running_Sum_of_1d_Array
{
    /// <summary>
    /// Computes a modified running sum of the input array, where each element is replaced by the difference between
    /// itself and the previous element.
    /// </summary>
    /// <remarks>This method modifies the input array in place. The caller should ensure that the input array
    /// is not shared or reused elsewhere if the original values are needed.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para>
    /// </remarks>
    /// <param name="nums">An array of integers. Must not be null.</param>
    /// <returns>An array of integers where each element represents the difference between the current and previous elements in
    /// the original array. The first element remains unchanged.</returns>
    public int[] RunningSum_Overridden(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] -= nums[i - 1];
        }

        return nums;
    }

    /// <summary>
    /// Calculates the running sum of an array, where each element at index <c>i</c> is the sum of all elements from
    /// index <c>0</c> to <c>i</c> in the input array.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(n) because a new array of the same length as the input is created.</para>
    /// </summary>
    /// <remarks>This method processes the input array in a single pass, making it efficient for large
    /// arrays.</remarks>
    /// <param name="nums">The input array of integers. Must not be <see langword="null"/>.</param>
    /// <returns>An array of integers representing the running sum of the input array. The returned array will have the same
    /// length as the input array.</returns>
    public int[] RunningSum(int[] nums)
    {
        int[] runningSum = new int[nums.Length];

        // The first element is the same as in the input array
        runningSum[0] = nums[0];

        // Start from the second element and calculate the running sum
        for (int i = 1; i < nums.Length; i++)
        {
            runningSum[i] = runningSum[i - 1] + nums[i];
        }

        return runningSum;
    }
}