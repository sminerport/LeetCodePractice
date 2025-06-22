namespace Problems;

/// <summary>
/// Provides methods to calculate the product of all elements in an array except the element at each index.
/// </summary>
/// <remarks>This class includes methods for computing the product of array elements excluding the current index,
/// both with a two-pass approach and an optimized single-pass approach. These methods avoid division  and operate with
/// O(n) time complexity. The input array must not be null, and its length must be at least 1.</remarks>
public class P238_Product_of_Array_Except_Self
{
    /// <summary>
    /// Calculates the product of all elements in the input array except the element at each index.
    /// </summary>
    /// <remarks>This method does not use division and computes the result in O(n) time complexity by
    /// utilizing two auxiliary arrays to store prefix and suffix products. The input array <paramref name="nums"/> must
    /// not be null.</remarks>
    /// <param name="nums">An array of integers for which the product of all elements except the current index will be calculated.</param>
    /// <returns>An array of integers where each element at index <c>i</c> is the product of all elements in <paramref
    /// name="nums"/> except the element at index <c>i</c>.</returns>
    public int[] ProductExceptSelf_TwoPass(int[] nums)
    {
        int[] R = new int[nums.Length];
        int[] L = new int[nums.Length];
        int[] result = new int[nums.Length];

        L[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            L[i] = L[i - 1] * nums[i - 1];
        }

        R[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            R[i] = R[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = L[i] * R[i];
        }

        return result;
    }

    /// <summary>
    /// Calculates the product of all elements in the input array except the element at each index,  using a single-pass
    /// approach for optimal performance.
    /// </summary>
    /// <remarks>This method avoids division and computes the result in O(n) time complexity using two passes:
    /// one to calculate the prefix products and another to incorporate the suffix products. The input array must not be
    /// null, and its length must be at least 1.</remarks>
    /// <param name="nums">An array of integers for which the product of all elements except the current index will be calculated.</param>
    /// <returns>An array of integers where each element at index <c>i</c> is the product of all elements in the input array
    /// except the element at index <c>i</c>.</returns>
    public static int[] ProductExceptSelf_InPlace(int[] nums)
    {
        int[] answer = new int[nums.Length];
        answer[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        int R = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= R;
            R *= nums[i];
        }

        return answer;
    }
}