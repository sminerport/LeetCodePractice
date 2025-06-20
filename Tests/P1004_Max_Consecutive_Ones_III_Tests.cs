namespace Tests;

public class P1004_Max_Consecutive_Ones_III_Tests
{
    [Fact]
    public void LongestOnes_Example1()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 1, 0, 0, 1, 1, 1, 0, 1 };
        int k = 2;
        int expected = 7;
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_Example2()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 0, 0, 1, 1, 1, 0, 1, 1 };
        int k = 1;
        int expected = 6;
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_Example3()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 0, 1, 0, 1, 0, 1 };
        int k = 2;
        int expected = 5;
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_EmptyArray()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { };
        int k = 2;
        int expected = 0;
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_AllOnes()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 1, 1, 1, 1 };
        int k = 2;
        int expected = 5;
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_AllZeros()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 0, 0, 0, 0, 0 };
        int k = 2;
        int expected = 2; // Flipping two zeros to ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_LargeInput()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = new int[1_000_000];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i % 2; // Alternating 0s and 1s
        }
        int k = 500_000; // Allow flipping half of the zeros
        int expected = 1_000_000; // All can be made ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_SingleElementArray()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 0 };
        int k = 1;
        int expected = 1; // Flipping the single zero to one
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_MultipleZerosAndOnes()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 0, 0, 1, 1, 0, 1, 0, 1 };
        int k = 3;
        int expected = 7; // Flipping the three zeros to ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_NoFlipsNeeded()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 1, 1, 0, 1, 1 };
        int k = 0; // No flips allowed
        int expected = 3; // The longest contiguous ones without flips
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_ZeroK()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 0, 1, 0, 1 };
        int k = 0; // No flips allowed
        int expected = 1; // The longest contiguous ones without flips
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_AllZerosWithK()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 0, 0, 0, 0, 0 };
        int k = 3; // Allow flipping three zeros to ones
        int expected = 3; // Flipping three zeros to ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_AlternatingPattern()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 0, 1, 0, 1, 0, 1 };
        int k = 2; // Allow flipping two zeros to ones
        int expected = 5; // Flipping two zeros to ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_LargeK()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 0, 1, 0, 1, 0, 1 };
        int k = 10; // Allow flipping more zeros than present
        int expected = 6; // All can be made ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_ConsecutiveZerosAtStart()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 0, 0, 1, 1, 1, 0, 1 };
        int k = 2; // Allow flipping two zeros to ones
        int expected = 6; // Flipping the two leading zeros to ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_ConsecutiveZerosAtEnd()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 1, 0, 0, 1, 1, 0 };
        int k = 2; // Allow flipping two zeros to ones
        int expected = 6; // Flipping the two trailing zeros to ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }

    [Fact]
    public void LongestOnes_ConsecutiveZerosInMiddle()
    {
        var solution = new Problems.P1004_Max_Consecutive_Ones_III();
        int[] nums = { 1, 0, 0, 1, 0, 1, 1 };
        int k = 2; // Allow flipping two zeros to ones
        int expected = 5; // Flipping the two middle zeros to ones
        Assert.Equal(expected, solution.LongestOnes(nums, k));
    }
}