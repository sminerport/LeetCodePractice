namespace Problems;

/// <summary>
/// Provides methods to calculate the maximum number of unique pairs of integers in an array whose sum equals a
/// specified target value.
/// </summary>
/// <remarks>This class includes multiple implementations for solving the problem, such as using a hash map or a
/// two-pointer approach. Each method is designed to efficiently find pairs while adhering to constraints that each
/// integer can only be used in one pair.</remarks>
public class P1679_Max_Number_of_K_Sum_Pairs
{
    /// <summary>
    /// Determines the maximum number of unique pairs of integers in the array that sum to the specified target value.
    /// </summary>
    /// <remarks>Each pair consists of two distinct integers from the array, and each integer can only be used
    /// in one pair. The method uses a single-pass approach with a hash map to efficiently track the frequency of
    /// integers and their complements.</remarks>
    /// <param name="nums">An array of integers to search for pairs.</param>
    /// <param name="k">The target sum for each pair of integers.</param>
    /// <returns>The maximum number of unique pairs of integers whose sum equals <paramref name="k"/>.</returns>
    public int MaxOperations_SinglePassHashMap(int[] nums, int k)
    {
        var frequencyMap = new Dictionary<int, int>();
        int count = 0;
        foreach (int num in nums)
        {
            int complement = k - num;
            // Check if the complement exists in the map
            if (frequencyMap.TryGetValue(complement, out int complementCount) && complementCount > 0)
            {
                // Use one of the complement to form a pair
                frequencyMap[complement] = complementCount - 1;
                count++;
            }
            else
            {
                // If complement not found, add the current number to the map
                if (!frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num] = 0;
                }
                frequencyMap[num]++;
            }
        }
        return count;
    }

    /// <summary>
    /// Calculates the maximum number of unique pairs of integers in the array whose sum equals the specified target
    /// value.
    /// </summary>
    /// <remarks>Each pair consists of two distinct integers from the array, and each integer can only be used
    /// in one pair. If no pairs can be formed, the method returns 0.</remarks>
    /// <param name="nums">An array of integers to search for pairs.</param>
    /// <param name="k">The target sum for each pair of integers.</param>
    /// <returns>The maximum number of unique pairs of integers whose sum equals <paramref name="k"/>.</returns>
    public int MaxOperations_TwoPassHashMap(int[] nums, int k)
    {
        // Build a frequency map of all numbers in the array
        var frequencyMap = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (!frequencyMap.ContainsKey(num))
            {
                frequencyMap[num] = 0;
            }
            frequencyMap[num]++;
        }

        int count = 0;

        // For each number, try to form a pair with its complement
        foreach (int num in nums)
        {
            int complement = k - num;

            frequencyMap.TryGetValue(num, out int numCount);
            frequencyMap.TryGetValue(complement, out int complementCount);

            // Both must be available to form a pair
            if (numCount > 0 && complementCount > 0)
            {
                // If num == complement, need at least two of them to form a pair
                if (num == complement && numCount < 2)
                {
                    continue;
                }

                // Use one of each to form a pair
                frequencyMap[num]--;
                frequencyMap[complement]--;
                count++;
            }
        }

        return count;
    }

    /// <summary>
    /// Determines the maximum number of unique pairs in the sorted array whose sum equals the specified target value.
    /// </summary>
    /// <remarks>This method uses a two-pointer approach to efficiently find pairs in a sorted array. The
    /// input array is sorted internally, which modifies its order. Each pair is counted only once, and the pointers are
    /// adjusted to avoid reusing elements.</remarks>
    /// <param name="nums">An array of integers to search for pairs. The array will be sorted internally.</param>
    /// <param name="k">The target sum for the pairs.</param>
    /// <returns>The maximum number of unique pairs whose sum equals <paramref name="k"/>.</returns>
    public int MaxOperations_TwoPointerSorted(int[] nums, int k)
    {
        Array.Sort(nums);
        int left = 0, right = nums.Length - 1;
        int count = 0;
        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum < k)
            {
                left++;
            }
            else if (sum > k)
            {
                right--;
            }
            else
            {
                count++;
                left++;
                right--;
            }
        }
        return count;
    }
}