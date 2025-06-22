using Problems;

namespace Tests;

public class P0344_Reverse_String_Tests
{
    [Theory]
    [InlineData(new[] {'h','e','l','l','o'}, new[] {'o','l','l','e','h'})]
    [InlineData(new[] {'H','a','n','n','a','h'}, new[] {'h','a','n','n','a','H'})]
    public void ReverseString_ModifiesArrayInPlace(char[] input, char[] expected)
    {
        var solver = new P0344_Reverse_String();
        solver.ReverseString(input);
        Assert.Equal(expected, input);
    }
}
