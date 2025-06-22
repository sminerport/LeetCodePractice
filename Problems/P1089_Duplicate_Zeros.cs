namespace Problems;

/// <summary>
/// LeetCode problem 1089. Duplicate Zeros. Duplicate each occurrence of zero in-place shifting the remaining elements.
/// </summary>
/// <remarks>
/// Category: In-place Array
/// LeetCode link: https://leetcode.com/problems/duplicate-zeros/
/// </remarks>
public class P1089_Duplicate_Zeros
{
    /// <summary>
    /// Modifies the input array by duplicating each occurrence of zero, shifting the remaining elements to the right.
    /// Only elements within the original array length are retained; excess elements are truncated.
    /// </summary>
    /// <remarks>This method operates in-place and does not return a new array. The array's size remains
    /// unchanged,  and elements shifted beyond the original array length are discarded. The method uses a two-pointer
    /// approach to efficiently duplicate zeros without requiring additional memory.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="arr">The array to modify. Must be a non-null array of integers.</param>
    public void DuplicateZeros_TwoPointerBackward(int[] arr)
    {
        int n = arr.Length;
        int zeros = 0;

        foreach (var x in arr)
        {
            if (x == 0)
                zeros++;
        }

        for (int i = n - 1, j = n + zeros - 1; i >= 0; i--, j--)
        {
            if (j < n)
                arr[j] = arr[i];

            if (arr[i] == 0)
            {
                j--;
                if (j < n)
                    arr[j] = 0; // Duplicate the zero
            }
        }
    }

    /// <summary>
    /// Duplicates each occurrence of zero in the specified array by shifting subsequent elements to the right.
    /// </summary>
    /// <remarks>This method modifies the input array in place. When a zero is encountered, all subsequent
    /// elements are shifted to the right to make space for the duplicated zero. The array's size remains unchanged, and
    /// elements at the end of the array may be overwritten during the shifting process.
    /// <para>Time complexity: O(n<sup>2</sup>) in the worst case.</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="arr">The array of integers to process. The array must have sufficient space to accommodate the duplicated zeros.</param>
    public void DuplicateZeros_ShiftOnZero(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                for (int j = arr.Length - 2; j >= i; j--)
                {
                    arr[j + 1] = arr[j]; // Shift elements to the right
                }

                i++; // Skip the next element since we just duplicated a zero
            }
        }
    }
}