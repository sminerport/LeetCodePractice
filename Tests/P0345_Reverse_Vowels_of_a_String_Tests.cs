using Problems;

namespace Tests;

public class P0345_Reverse_Vowels_of_a_String_Tests
{
    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("leetcode", "leotcede")]
    [InlineData("aA", "Aa")]
    [InlineData("", "")]
    [InlineData("bcdfg", "bcdfg")]
    public void ReverseVowels_Works(string input, string expected)
    {
        string result = P0345_Reverse_Vowels_of_a_String.ReverseVowels(input);
        Assert.Equal(expected, result);
    }
}
