using Problems;

namespace Tests;

public class P485_Max_Consecutive_Ones_Tests
{
    [Theory]
    [InlineData(new[] {1,1,0,1,1,1}, 3)]
    [InlineData(new[] {1,0,1,1,0,1}, 2)]
    [InlineData(new[] {0,0,0}, 0)]
    [InlineData(new[] {1,1,1,1}, 4)]
    public void FindMaxConsecutiveOnes_MethodsReturnSame(int[] nums, int expected)
    {
        var solver = new P485_Max_Consecutive_Ones();
        Assert.Equal(expected, solver.FindMaxConsecutiveOnesUsingWindow(nums));
        Assert.Equal(expected, solver.FindMaxConsecutiveOnesLinearScan(nums));
    }
}
