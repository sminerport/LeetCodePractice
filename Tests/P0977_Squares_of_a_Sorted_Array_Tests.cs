using Problems;

namespace Tests;

public class P977_Squares_of_a_Sorted_Array_Tests
{
    [Theory]
    [InlineData(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
    [InlineData(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
    [InlineData(new[] { -1, 1 }, new[] { 1, 1 })]
    public void SortedSquaresWithBuiltInSort(int[] input, int[] expected)
    {
        var result = P977_Squares_of_a_Sorted_Array.SortedSquaresWithBuiltInSort(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
    [InlineData(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
    [InlineData(new[] { -1, 1 }, new[] { 1, 1 })]
    public void SortedSquaresWithBubbleSort(int[] input, int[] expected)
    {
        var result = P977_Squares_of_a_Sorted_Array.SortedSquaresWithBubbleSort(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
    [InlineData(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
    [InlineData(new[] { -1, 1 }, new[] { 1, 1 })]
    public void SortedSquaresWithLINQ(int[] input, int[] expected)
    {
        var result = P977_Squares_of_a_Sorted_Array.SortedSquaresWithLINQ(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { -4, -1, 0, 3, 10 }, new[] { 0, 1, 9, 16, 100 })]
    [InlineData(new[] { -7, -3, 2, 3, 11 }, new[] { 4, 9, 9, 49, 121 })]
    [InlineData(new[] { -1, 1 }, new[] { 1, 1 })]
    public void SortedSquaresWithTwoPointers(int[] input, int[] expected)
    {
        var result = P977_Squares_of_a_Sorted_Array.SortedSquaresWithTwoPointers(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { -1 }, new[] { 1 })]
    [InlineData(new[] { 1 }, new[] { 1 })]
    [InlineData(new[] { -2, 2 }, new[] { 4, 4 })]
    [InlineData(new[] { -3, 0, 3 }, new[] { 0, 9, 9 })]
    [InlineData(new[] { -5, 0, 5 }, new[] { 0, 25, 25 })]
    [InlineData(new[] { -10, -5, 0, 5, 10 }, new[] { 0, 25, 25, 100, 100 })]
    [InlineData(new[] { -10, -5, 0, 5, 10, 15 }, new[] { 0, 25, 25, 100, 100, 225 })]
    [InlineData(new[] { -3, -2, -1, 0, 1, 2, 3 }, new[] { 0, 1, 1, 4, 4, 9, 9 })]
    [InlineData(new[] { -100, -50, 0, 50, 100 }, new[] { 0, 2500, 2500, 10000, 10000 })]
    [InlineData(new[] { -1000, -500, 0, 500, 1000 }, new[] { 0, 250000, 250000, 1000000, 1000000 })]
    [InlineData(new[] { -1000, -500, 0, 500, 1000, 2000 }, new[] { 0, 250000, 250000, 1000000, 1000000, 4000000 })]
    [InlineData(new[] { -1000, -500, 0, 500, 1000, 2000, 3000 }, new[] { 0, 250000, 250000, 1000000, 1000000, 4000000, 9000000 })]
    [InlineData(new[] { -1000, -500, 0, 500, 1000, 2000, 3000, 4000 }, new[] { 0, 250000, 250000, 1000000, 1000000, 4000000, 9000000, 16000000 })]
    public void EdgeCases(int[] input, int[] expected)
    {
        var resultBuiltIn = P977_Squares_of_a_Sorted_Array.SortedSquaresWithBuiltInSort(input);
        Assert.Equal(expected, resultBuiltIn);
        var resultBubble = P977_Squares_of_a_Sorted_Array.SortedSquaresWithBubbleSort(input);
        Assert.Equal(expected, resultBubble);
        var resultLINQ = P977_Squares_of_a_Sorted_Array.SortedSquaresWithLINQ(input);
        Assert.Equal(expected, resultLINQ);
        var resultTwoPointers = P977_Squares_of_a_Sorted_Array.SortedSquaresWithTwoPointers(input);
        Assert.Equal(expected, resultTwoPointers);
    }
}