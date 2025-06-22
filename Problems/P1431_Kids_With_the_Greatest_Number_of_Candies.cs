namespace Problems;

/// <summary>
/// Determines which children can have the greatest number of candies if given extra candies.
/// </summary>
/// <remarks>This method evaluates each child's candy count and determines whether adding the specified  number of
/// extra candies would make their total equal to or exceed the maximum candy count  among all children. The result is a
/// list of boolean values indicating whether each child  meets this condition.</remarks>
public class P1431_Kids_With_the_Greatest_Number_of_Candies
{
    /// <summary>
    /// Determines whether each child can have the greatest number of candies if given extra candies.
    /// </summary>
    /// <remarks>This method calculates whether each child can have at least as many candies as the child with
    /// the current maximum number of candies, after adding the specified number of extra candies.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(n) for the result list.</para></remarks>
    /// <param name="candies">An array representing the number of candies each child currently has.</param>
    /// <param name="extraCandies">The number of extra candies to distribute to each child.</param>
    /// <returns>A list of boolean values where each element corresponds to a child and is <see langword="true"/> if the child
    /// can have the greatest number of candies after receiving the extra candies; otherwise, <see langword="false"/>.</returns>
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxCandies = candies.Max();
        var result = new List<bool>();
        foreach (int candy in candies)
        {
            result.Add(candy + extraCandies >= maxCandies);
        }
        return result;
    }
}