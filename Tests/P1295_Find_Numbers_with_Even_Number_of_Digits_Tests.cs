using Problems;

namespace Tests;

public class P1295_Find_Numbers_with_Even_Number_of_Digits_Tests
{
    [Theory]
    [InlineData(new[] {12,345,2,6,7896}, 2)]
    [InlineData(new[] {555,901,482,1771}, 1)]
    [InlineData(new[] {1,2,3,4}, 0)]
    public void FindNumbers_AllImplementations_ReturnSame(int[] nums, int expected)
    {
        var solver = new P1295_Find_Numbers_with_Even_Number_of_Digits();
        Assert.Equal(expected, solver.FindNumbers_Range(nums));
        Assert.Equal(expected, solver.FindNumbers_Log10(nums));
        Assert.Equal(expected, solver.FindNumbers_String(nums));
        Assert.Equal(expected, solver.FindNumbers_Divide(nums));
    }
}
