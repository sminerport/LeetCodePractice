using Problems;

namespace Tests;

public class P1089_Duplicate_Zeros_Tests
{
    [Theory]
    [InlineData(new int[] {1,0,2,3,0,4,5,0}, new int[] {1,0,0,2,3,0,0,4})]
    [InlineData(new int[] {1,2,3}, new int[] {1,2,3})]
    [InlineData(new int[] {0,0,0,0,0}, new int[] {0,0,0,0,0})]
    public void DuplicateZeros_TwoPointerBackward_Works(int[] input, int[] expected)
    {
        var sol = new P1089_Duplicate_Zeros();
        var arr = (int[])input.Clone();
        sol.DuplicateZeros_TwoPointerBackward(arr);
        Assert.Equal(expected, arr);
    }

    [Theory]
    [InlineData(new int[] {1,0,2,3,0,4,5,0}, new int[] {1,0,0,2,3,0,0,4})]
    [InlineData(new int[] {1,2,3}, new int[] {1,2,3})]
    [InlineData(new int[] {0,0,0,0,0}, new int[] {0,0,0,0,0})]
    public void DuplicateZeros_ShiftOnZero_Works(int[] input, int[] expected)
    {
        var sol = new P1089_Duplicate_Zeros();
        var arr = (int[])input.Clone();
        sol.DuplicateZeros_ShiftOnZero(arr);
        Assert.Equal(expected, arr);
    }
}
