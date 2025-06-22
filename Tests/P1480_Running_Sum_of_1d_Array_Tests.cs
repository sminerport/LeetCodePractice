using Problems;

namespace Tests;

public class P1480_Running_Sum_of_1d_Array_Tests
{
    [Theory]
    [InlineData(new[] {1,2,3,4}, new[] {1,3,6,10})]
    [InlineData(new[] {1,1,1,1,1}, new[] {1,2,3,4,5})]
    [InlineData(new[] {3,1,2,10,1}, new[] {3,4,6,16,17})]
    public void RunningSum_ReturnsExpected(int[] nums, int[] expected)
    {
        var solver = new P1480_Running_Sum_of_1d_Array();
        Assert.Equal(expected, solver.RunningSum(nums));
    }
}
