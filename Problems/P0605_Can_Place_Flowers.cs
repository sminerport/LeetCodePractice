namespace Problems;

/// <summary>
/// Provides methods to determine whether a specified number of flowers can be planted in a flowerbed without violating
/// the rule that no two flowers can be adjacent.
/// </summary>
/// <remarks>This class contains methods that simulate planting flowers in a flowerbed represented as an array.
/// The methods modify the input array during execution, so callers should create a copy of the array if the original
/// state needs to be preserved.</remarks>
public class P605_Can_Place_Flowers
{
    /// <summary>
    /// Determines whether it is possible to plant the specified number of flowers in the given flowerbed without
    /// violating the rule that no two flowers can be adjacent.
    /// </summary>
    /// <remarks>This method modifies the input <paramref name="flowerbed"/> array to simulate planting
    /// flowers. If the caller needs to preserve the original state of the array, a copy should be made before calling
    /// this method. The method uses an optimized approach to exit early if the required number of flowers has been
    /// planted.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="flowerbed">An array representing the flowerbed, where 0 indicates an empty spot and 1 indicates a spot already occupied by
    /// a flower.</param>
    /// <param name="n">The number of flowers to plant. Must be a non-negative integer.</param>
    /// <returns><see langword="true"/> if it is possible to plant at least <paramref name="n"/> flowers in the flowerbed without
    /// violating the adjacency rule; otherwise, <see langword="false"/>.</returns>
    public bool CanPlaceFlowers_Optimized(int[] flowerbed, int n)
    {
        int count = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0 &&
                (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1; // Plant a flower
                count++;
                if (count >= n)
                {
                    return true; // Early exit if we have planted enough flowers
                }
            }
        }

        return count >= n; // Check if we have planted at least n flowers
    }

    /// <summary>
    /// Determines whether it is possible to plant the specified number of flowers in the given flowerbed without
    /// violating the rule that no two flowers can be adjacent.
    /// </summary>
    /// <remarks>This method performs a single scan of the flowerbed array to determine the feasibility of
    /// planting the specified number of flowers. The flowerbed array is modified during the process to simulate
    /// planting flowers.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(1).</para></remarks>
    /// <param name="flowerbed">An array representing the flowerbed, where 0 indicates an empty spot and 1 indicates a spot already occupied by
    /// a flower.</param>
    /// <param name="n">The number of flowers to plant. Must be a non-negative integer.</param>
    /// <returns><see langword="true"/> if it is possible to plant <paramref name="n"/> flowers in the flowerbed without
    /// violating the adjacency rule; otherwise, <see langword="false"/>.</returns>
    public bool CanPlaceFlowers_SingleScan(int[] flowerbed, int n)
    {
        int count = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0 &&
                (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1; // Plant a flower
                count++;
            }
        }

        return count >= n;
    }
}