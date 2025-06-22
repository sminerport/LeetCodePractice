namespace Problems;

/// <summary>
/// Provides functionality to reverse the order of characters in an array in place.
/// </summary>
/// <remarks>This class is designed to reverse the elements of a character array directly, without allocating
/// additional memory. It is useful for scenarios where in-place modification of data is required.</remarks>
public class P0344_Reverse_String
{
    /// <summary>
    /// Reverses the order of characters in the specified array in place.
    /// </summary>
    /// <remarks>This method modifies the input array directly, reversing the order of its elements. The
    /// operation is performed in place, meaning no additional memory is allocated for the reversal.</remarks>
    /// <param name="s">The array of characters to reverse. The array must not be null.</param>
    public void ReverseString(char[] s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            // swap s[left] and s[right]
            char tmp = s[left];
            s[left++] = s[right];
            s[right--] = tmp;
        }
    }
}