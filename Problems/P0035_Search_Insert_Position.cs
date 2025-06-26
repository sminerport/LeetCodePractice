namespace Problems;

/// <summary>
/// Provides functionality to search for a target value in a sorted array and determine its position.
/// </summary>
/// <remarks>This class includes methods for performing binary search operations on sorted arrays. It is designed
/// to efficiently locate a target value or determine the appropriate insertion index to maintain the  sorted order of
/// the array.</remarks>
public class P0035_Search_Insert_Position
{
    /// <summary>
    /// Determines the index at which the specified target value should be inserted in a sorted array.
    /// </summary>
    /// <remarks>This method performs a linear search, which may be less efficient for large arrays. Consider
    /// using a binary search approach for better performance with larger datasets.</remarks>
    /// <param name="nums">A sorted array of integers in ascending order.</param>
    /// <param name="target">The target value to search for or determine the insertion point.</param>
    /// <returns>The index of the first element in <paramref name="nums"/> that is greater than or equal to <paramref
    /// name="target"/>, or the length of <paramref name="nums"/> if <paramref name="target"/> is greater than all
    /// elements in the array.</returns>
    public int SearchInsert_Linear(int[] nums, int target)
    {
        // Linear search to find the target or the insertion point
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
            {
                return i; // Return the index if target is found or the first element greater than target
            }
        }
        // target is larger than all elements
        return nums.Length;
    }

    /// <summary>
    /// Searches for the specified target value in a sorted array using binary search. If the target is not found,
    /// returns the index where it should be inserted to maintain the sorted order.
    /// </summary>
    /// <remarks>This method assumes that the input array <paramref name="nums"/> is sorted in ascending
    /// order. If the array is not sorted, the behavior of this method is undefined.</remarks>
    /// <param name="nums">A sorted array of integers in ascending order.</param>
    /// <param name="target">The value to search for in the array.</param>
    /// <returns>The index of the target value if found; otherwise, the index where the target should be inserted to maintain the
    /// sorted order.</returns>
    public int SearchInsert_Binary(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid; // Target found
            }
            else if (nums[mid] < target)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }

        // If target is not found, left is the insertion point
        return left; // Return the index where target should be inserted
    }
}