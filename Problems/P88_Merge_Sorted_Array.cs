namespace Problems;

/// <summary>
/// Provides methods for merging arrays, including merging sorted arrays into a single sorted array.
/// </summary>
/// <remarks>This class contains utility methods for merging arrays, such as concatenating and sorting arrays or
/// merging two sorted arrays. The methods are designed to modify the first array in-place, ensuring it contains the
/// merged result.</remarks>
public class P88_Merge_Sorted_Array
{
    /// <summary>
    /// Merges two arrays by concatenating the elements of the second array into the first array and then sorting
    /// the resulting array in ascending order.
    /// </summary>
    /// <remarks>After the operation, <paramref name="nums1"/> will contain all elements from both arrays,
    /// sorted in ascending order. Ensure that <paramref name="nums1"/> has a length of at least <paramref
    /// name="m"/> + <paramref name="n"/> to avoid overwriting memory outside the bounds of the array.</remarks>
    /// <param name="nums1">The first array, which must have sufficient space to hold the elements of both arrays. The first <paramref
    /// name="m"/> elements are considered valid.</param>
    /// <param name="m">The number of valid elements in <paramref name="nums1"/>.</param>
    /// <param name="nums2">The second array, containing <paramref name="n"/> elements to be merged into <paramref name="nums1"/>.</param>
    /// <param name="n">The number of elements in <paramref name="nums2"/>.</param>
    public void Merge_ConcatenateAndSort(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = m, j = 0; j < n; i++, j++)
        {
            nums1[i] = nums2[j];
        }
        Array.Sort(nums1);
    }

    /// <summary>
    /// Merges two sorted arrays into a single sorted array.
    /// </summary>
    /// <remarks>This method merges the elements of <paramref name="nums2"/> into <paramref name="nums1"/> in
    /// sorted order. The <paramref name="nums1"/> array must have sufficient space to hold all elements from both
    /// arrays. The result is stored in <paramref name="nums1"/>.</remarks>
    /// <param name="nums1">The first sorted array, which contains the initial elements followed by a buffer of zeros to accommodate the
    /// merged result.</param>
    /// <param name="m">The number of valid elements in <paramref name="nums1"/>.</param>
    /// <param name="nums2">The second sorted array to merge into <paramref name="nums1"/>.</param>
    /// <param name="n">The number of valid elements in <paramref name="nums2"/>.</param>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;      // last valid in nums1
        int j = n - 1;      // last in nums2
        int k = m + n - 1;  // last position in nums1 buffer

        // Fill nums1[k] from the largest tail elements:
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
                nums1[k--] = nums1[i--];
            else
                nums1[k--] = nums2[j--];
        }

        // If any nums2 elements remain, copy them:
        while (j >= 0)
        {
            nums1[k--] = nums2[j--];
        }
    }
}