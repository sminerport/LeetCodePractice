namespace Problems;

internal class P977_Squares_of_a_Sorted_Array
{
    /// <summary>
    /// Sorts the squares of the integers in the specified array in ascending order using the Bubble Sort algorithm.
    /// </summary>
    /// <remarks>This method sorts the squares of the integers in the specified array in ascending order.</remarks>
    public static int[] SortedSquaresWithBubbleSort(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                    swapped = true;
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        return nums;
    }

    /// <summary>
    /// Computes the squares of the elements in the input array and returns them sorted in ascending order.
    /// </summary>
    /// <param name="nums">An array of integers to be squared and sorted. Cannot be null.</param>
    /// <returns>An array of integers containing the squared values of the input array, sorted in ascending order.</returns>
    public static int[] SortedSquaresWithBuiltInSort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] *= nums[i]; // Square each element
        }
        Array.Sort(nums);
        return nums;
    }

    /// <summary>
    /// Computes the squares of the elements in the input array and returns them in ascending order.
    /// </summary>
    /// <remarks>This method uses LINQ to perform the operations. It first computes the square of each element
    /// in the input array and then sorts the resulting values in ascending order.</remarks>
    /// <param name="nums">An array of integers to be squared and sorted.</param>
    /// <returns>An array of integers containing the squares of the input elements, sorted in ascending order.</returns>
    public static int[] SortedSquaresWithLINQ(int[] nums)
    {
        // Using LINQ to square each element and sort the result
        return nums.Select(x => x * x).OrderBy(x => x).ToArray();
    }

    /// <summary>
    /// Returns a new array containing the squares of the elements in the input array, sorted in non-decreasing order.
    /// </summary>
    /// <remarks>This method efficiently computes the result using a two-pointer approach, ensuring a time
    /// complexity of O(n). The input array does not need to be pre-sorted.</remarks>
    /// <param name="nums">An array of integers. The array can contain positive, negative, or zero values.</param>
    /// <returns>An array of integers where each element is the square of the corresponding element in the input array, sorted in
    /// non-decreasing order.</returns>
    public static int[] SortedSquaresWithTwoPointers(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        int left = 0, right = n - 1;

        for (int idx = n - 1; idx >= 0; idx--)
        {
            // Pick the larger square from either end
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[idx] = nums[left] * nums[left++];
            }
            else
            {
                result[idx] = nums[right] * nums[right--];
            }
        }

        return result;
    }
}