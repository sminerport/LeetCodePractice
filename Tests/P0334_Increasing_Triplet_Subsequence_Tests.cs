using Problems;

namespace Tests;

public class P0334_Increasing_Triplet_Subsequence_Tests
{
    [Theory]
    [InlineData(new[] {1,2,3,4,5}, true)]
    [InlineData(new[] {5,4,3,2,1}, false)]
    [InlineData(new[] {2,1,5,0,4,6}, true)]
    [InlineData(new[] {20,100,10,12,5,13}, true)]
    public void IncreasingTriplet_ReturnsExpected(int[] nums, bool expected)
    {
        var solver = new P0334_Increasing_Triplet_Subsequence();
        Assert.Equal(expected, solver.IncreasingTriplet(nums));
    }
}
