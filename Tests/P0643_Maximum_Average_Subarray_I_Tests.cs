using Problems;

namespace Tests;

public class P643_Maximum_Average_Subarray_I_Tests
{
    [Theory]
    [InlineData(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75)]
    [InlineData(new[] { 5, 5, 5, 5, 5 }, 1, 5.0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 2, 4.5)]
    [InlineData(new[] { -1, -2, -3, -4, -5 }, 3, -2.0)]
    [InlineData(new[] { 0, 0, 0, 0, 0, 0 }, 3, 0.0)]
    public void FindMaxAverage_Examples(int[] nums, int k, double expected)
    {
        double result = P643_Maximum_Average_Subarray_I.FindMaxAverage(nums, k);
        Assert.Equal(expected, result, 2); // Using 2 decimal places for precision
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, 3.0)]
    [InlineData(new[] { 10, 20, 30, 40, 50 }, 1, 50.0)]
    [InlineData(new[] { -10, -20, -30, -40, -50 }, 2, -15.0)]
    [InlineData(new[] { 100, 200, 300, 400, 500 }, 4, 350.0)]
    public void FindMaxAverage_AdditionalExamples(int[] nums, int k, double expected)
    {
        double result = P643_Maximum_Average_Subarray_I.FindMaxAverage(nums, k);
        Assert.Equal(expected, result, 2); // Using 2 decimal places for precision
    }
}