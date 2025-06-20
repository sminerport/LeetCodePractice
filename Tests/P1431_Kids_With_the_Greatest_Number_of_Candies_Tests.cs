using System.Linq;
using Problems;

namespace Tests;

public class P1431_Kids_With_the_Greatest_Number_of_Candies_Tests
{
    [Theory]
    [InlineData(new[] {2,3,5,1,3}, 3, new[] {true,true,true,false,true})]
    [InlineData(new[] {4,2,1,1,2}, 1, new[] {true,false,false,false,false})]
    [InlineData(new[] {12,1,12}, 10, new[] {true,false,true})]
    public void KidsWithCandies_ReturnsExpected(int[] candies, int extra, bool[] expected)
    {
        var solver = new P1431_Kids_With_the_Greatest_Number_of_Candies();
        var result = solver.KidsWithCandies(candies, extra).ToArray();
        Assert.Equal(expected, result);
    }
}
