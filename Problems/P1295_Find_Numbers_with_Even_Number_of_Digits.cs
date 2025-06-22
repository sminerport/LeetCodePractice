namespace Problems;

/// <summary>
/// Provides methods to count numbers with an even number of digits in an array.
/// </summary>
/// <remarks>This class contains multiple implementations for determining whether numbers in an array have an even
/// number of digits. Each method uses a different approach, such as logarithmic calculations, string manipulation, or
/// iterative division.</remarks>
public class P1295_Find_Numbers_with_Even_Number_of_Digits
{
    /// <summary>
    /// Counts the numbers in the specified array that have an even number of digits.
    /// </summary>
    /// <remarks>A number is considered to have an even number of digits if its digit count is 2, 4, or 6.
    /// This method evaluates each number in the array and increments the count for numbers that meet this
    /// criterion.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="nums">An array of integers to evaluate.</param>
    /// <returns>The count of numbers in the array that have 2, 4, or 6 digits.</returns>
    public int FindNumbers_Range(int[] nums)
    {
        int evenCount = 0;
        foreach (int num in nums)
        {
            if ((num >= 10 && num < 100) || // 2 digits
                (num >= 1000 && num < 10000) || // 4 digits
                (num >= 100000 && num < 1000000)) // 6 digits
            {
                evenCount++;
            }
        }

        return evenCount;
    }

    /// <summary>
    /// Counts the numbers in the specified array that have an even number of digits.
    /// </summary>
    /// <remarks>This method uses the base-10 logarithm to determine the number of digits in each number.
    /// Numbers with an even number of digits are identified and counted.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="nums">An array of integers to evaluate. Each integer must be non-negative.</param>
    /// <returns>The count of numbers in <paramref name="nums"/> that have an even number of digits.</returns>
    public int FindNumbers_Log10(int[] nums)
    {
        int evenCount = 0;
        foreach (int num in nums)
        {
            int digits = (int)Math.Log10(num) + 1; // Calculate the number of digits
            if ((digits & 1) == 0)
            {
                evenCount++;
            }
        }
        return evenCount;
    }

    /// <summary>
    /// Counts the numbers in the specified array that have an even number of digits.
    /// </summary>
    /// <param name="nums">An array of integers to evaluate. Cannot be null.</param>
    /// <returns>The count of numbers in the array that have an even number of digits.</returns>
    /// <remarks>
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para>
    /// </remarks>
    public int FindNumbers_String(int[] nums)
    {
        int count = 0;
        foreach (int num in nums)
        {
            if (num.ToString().Length % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    /// <summary>
    /// Counts the numbers in the specified array that have an even number of digits.
    /// </summary>
    /// <remarks>A number is considered to have an even number of digits if the total number of digits in its
    /// decimal representation is divisible by 2.
    /// <para>Time complexity: O(n log m) where m is the largest number.</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="nums">An array of integers to evaluate.</param>
    /// <returns>The count of numbers in <paramref name="nums"/> that have an even number of digits.</returns>
    public int FindNumbers_Divide(int[] nums)
    {
        int evenCount = 0;
        foreach (int num in nums)
        {
            int digits = 0, x = num;
            while (x > 0)
            {
                digits++;
                x /= 10;
            }
            if ((digits & 1) == 0) // Check if the number of digits is even
            {
                evenCount++;
            }
        }
        return evenCount;
    }
}