using Problems;

namespace Tests;

public class P0605_Can_Place_Flowers_Tests
{
    [Theory]
    [InlineData(new[] {1,0,0,0,1}, 1, true)]
    [InlineData(new[] {1,0,0,0,1}, 2, false)]
    [InlineData(new[] {0}, 1, true)]
    [InlineData(new[] {0,0,1,0,0}, 2, true)]
    public void CanPlaceFlowers_BothImplementations_ReturnSame(int[] flowerbed, int n, bool expected)
    {
        var solver = new P605_Can_Place_Flowers();
        int[] bed1 = (int[])flowerbed.Clone();
        int[] bed2 = (int[])flowerbed.Clone();
        Assert.Equal(expected, solver.CanPlaceFlowers_Optimized(bed1, n));
        Assert.Equal(expected, solver.CanPlaceFlowers_SingleScan(bed2, n));
    }
}
