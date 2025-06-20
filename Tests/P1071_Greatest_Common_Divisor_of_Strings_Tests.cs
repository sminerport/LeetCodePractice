using Problems;

namespace Tests;

public class P1071_Greatest_Common_Divisor_of_Strings_Tests
{
    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("LEET", "CODE", "")]
    [InlineData("A", "A", "A")]
    public void GcdOfStringsBruteForce_ReturnsExpected(string str1, string str2, string expected)
    {
        var gcd = new P1071_Greatest_Common_Divisor_of_Strings();
        var result = gcd.GcdOfStringsBruteForce(str1, str2);
        Assert.Equal(expected, result);
    }
}
