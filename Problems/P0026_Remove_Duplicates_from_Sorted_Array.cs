namespace Problems;

/// <summary>
/// Provides a solution to remove duplicate elements from a sorted array in-place.
/// </summary>
/// <remarks>This class contains a method that modifies a sorted array of integers to remove duplicate elements.
/// The operation is performed in-place, ensuring that the first part of the array contains only unique elements in
/// sorted order. The number of unique elements is returned as the result.</remarks>
public class P0026_Remove_Duplicates_from_Sorted_Array
{
    /// <summary>
    /// Removes duplicate elements from a sorted array in-place and returns the number of unique elements.
    /// </summary>
    /// <remarks>This method assumes the input array is sorted in ascending order. If the array is not sorted,
    /// the behavior is undefined. The method modifies the input array in-place, but only the first <see
    /// langword="return"/> value elements are guaranteed to contain valid data.</remarks>
    /// <param name="nums">A sorted array of integers. The array is modified in-place to contain only unique elements in the first part of
    /// the array, with the remaining elements undefined.</param>
    /// <returns>The number of unique elements in the array. The first <see langword="return"/> value elements of <paramref
    /// name="nums"/> will contain the unique elements in sorted order.</returns>
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int uniqueIndex = 0; // Index to place the next unique element
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueIndex])
            {
                uniqueIndex++;
                nums[uniqueIndex] = nums[i]; // Place the unique element at the next position
            }
        }
        return uniqueIndex + 1; // Return the count of unique elements
    }
}