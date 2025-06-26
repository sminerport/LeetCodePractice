namespace Problems;

/// <summary>
/// Provides methods to solve the "Two Sum" problem, which involves finding two numbers in an array that add up to a
/// specified target value.
/// </summary>
/// <remarks>This class contains implementations for solving the "Two Sum" problem using different approaches.
/// The methods return the indices of the two numbers that satisfy the condition, or an empty result if no such pair
/// exists.</remarks>
public class P0001_Two_Sum
{
    /// <summary>
    /// Finds the indices of two numbers in the specified array that add up to the given target value.
    /// </summary>
    /// <remarks>This method uses a brute-force approach, iterating through all possible pairs of numbers in
    /// the array. The indices returned are the first pair found that satisfies the condition. If multiple pairs exist,
    /// only the first pair encountered is returned.</remarks>
    /// <param name="nums">An array of integers to search for the pair of numbers.</param>
    /// <param name="target">The target sum to find in the array.</param>
    /// <returns>An array containing the indices of the two numbers that add up to the target value.  If no such pair exists,
    /// returns an empty array.</returns>
    public int[] TwoSum_BruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return Array.Empty<int>();
    }

    /// <summary>
    /// Finds two distinct indices in the array such that the numbers at those indices add up to the specified target.
    /// </summary>
    /// <remarks>This method uses a two-pass hash map approach to efficiently find the pair of indices.  The
    /// first pass builds a dictionary mapping numbers to their indices, and the second pass checks for
    /// complements.</remarks>
    /// <param name="nums">An array of integers to search for the pair.</param>
    /// <param name="target">The target sum to achieve by adding two numbers from the array.</param>
    /// <returns>An array containing the indices of the two numbers that add up to the target.  If no such pair exists, returns
    /// an empty array.</returns>
    public int[] TwoSum_TwoPassHashMap(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        // First pass: build a map of numbers to their indices
        for (int i = 0; i < nums.Length; i++)
        {
            map[nums[i]] = i;
        }

        // Second pass: check for each number if the complement exists in the map
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.TryGetValue(complement, out int index) && index != i)
            {
                return [i, index];
            }
        }

        return Array.Empty<int>();
    }

    /// <summary>
    /// Finds two distinct indices in the array such that the numbers at those indices add up to the specified target.
    /// </summary>
    /// <remarks>This method uses a single-pass hash map approach to achieve an efficient O(n) time
    /// complexity. The indices returned are guaranteed to be distinct.</remarks>
    /// <param name="nums">An array of integers to search for the pair.</param>
    /// <param name="target">The target sum to achieve by adding two numbers from the array.</param>
    /// <returns>An array containing the indices of the two numbers that add up to the target.  If no such pair exists, returns
    /// an empty array.</returns>
    public int[] TwoSum_SinglePassHashMap(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int index))
            {
                return [index, i];
            }

            // Store the index of the current number
            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}