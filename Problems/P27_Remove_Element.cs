namespace Problems;

/// <summary>
/// Provides methods for removing occurrences of a specified value from an array using different strategies.
/// </summary>
/// <remarks>The <see cref="P27_Remove_Element"/> class contains methods that modify an input array in-place to
/// remove all occurrences of a specified value. Each method employs a distinct approach, such as overwriting elements,
/// swapping elements, or shifting elements, to achieve the desired result. These methods return the count of remaining
/// valid elements in the array after the removal operation.</remarks>
public class P27_Remove_Element
{
    /// <summary>
    /// Removes all occurrences of a specified value from the array and overwrites the array with the remaining
    /// elements.
    /// </summary>
    /// <remarks>This method modifies the input array <paramref name="nums"/> in place by overwriting
    /// elements. The order of the remaining elements is preserved.</remarks>
    /// <param name="nums">The array of integers to process. The array will be modified in place.</param>
    /// <param name="val">The value to remove from the array.</param>
    /// <returns>The number of elements remaining in the array after removing all occurrences of <paramref name="val"/>.</returns>
    public int RemoveElement_Overwrite(int[] nums, int val)
    {
        int write = 0;

        for (int read = 0; read < nums.Length; read++)
        {
            if (nums[read] != val)
            {
                nums[write++] = nums[read];
            }
        }
        return write;
    }

    /// <summary>
    /// Removes all occurrences of a specified value from the given array using a two-pointer approach.
    /// </summary>
    /// <remarks>This method modifies the input array in-place and does not preserve the original order of
    /// elements. The caller should ensure that the array is not null before invoking this method.</remarks>
    /// <param name="nums">The array of integers to process. The array is modified in-place.</param>
    /// <param name="val">The value to remove from the array.</param>
    /// <returns>The number of elements removed from the array. The remaining elements in the array are shifted  to the front,
    /// and the order of elements may change.</returns>
    public int RemoveElement_Swap(int[] nums, int val)
    {
        int i = 0, n = nums.Length;

        while (i < n)
        {
            if (nums[i] == val)
            {
                // swap current with last unprocessed element
                nums[i] = nums[n - 1];
                n--;
            }
            else
            {
                i++;
            }
        }
        return n;
    }

    /// <summary>
    /// Removes all occurrences of the specified value from the array and shifts the remaining elements.
    /// </summary>
    /// <remarks>This method modifies the input array <paramref name="nums"/> in-place by shifting elements to
    /// fill gaps created by removing occurrences of <paramref name="val"/>. The method does not resize the array;
    /// instead, the caller should use the returned count to determine the valid portion of the array.</remarks>
    /// <param name="nums">The array of integers to process. This array will be modified in-place.</param>
    /// <param name="val">The value to remove from the array.</param>
    /// <returns>The number of elements remaining in the array after all occurrences of <paramref name="val"/> have been removed.</returns>
    public int RemoveElement_Shift(int[] nums, int val)
    {
        int k = nums.Length;

        for (int i = 0; i < k; i++)
        {
            if (nums[i] == val)
            {
                // shift everything left by one
                for (int j = i + 1; j < k; j++)
                {
                    nums[j - 1] = nums[j];
                }

                k--; // reduce the count of valid elements
                i--; // re-check this index (since it now has a new value)
            }
        }

        return k;
    }
}