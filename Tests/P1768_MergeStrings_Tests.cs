using Problems;

namespace Tests;

public class P1768_MergeStrings_Tests
{
    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    public void CharArray_Examples(string w1, string w2, string expected)
    {
        Assert.Equal(expected, MergeStrings1768.MergeWithCharArray(w1, w2));
    }

    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    public void StringBuilder_Examples(string w1, string w2, string expected)
    {
        Assert.Equal(expected, MergeStrings1768.MergeWithStringBuilder(w1, w2));
    }

    [Theory]
    [InlineData("hello", "world", "hweolrllod")]
    public void AdditionalExamples(string w1, string w2, string expected)
    {
        Assert.Equal(expected, MergeStrings1768.MergeWithStringBuilder(w1, w2));
    }

    [Theory]
    [InlineData("a", "b", "ab")]
    [InlineData("a", "", "a")]
    [InlineData("", "b", "b")]
    public void EdgeCases(string w1, string w2, string expected)
    {
        Assert.Equal(expected, MergeStrings1768.MergeWithCharArray(w1, w2));
        Assert.Equal(expected, MergeStrings1768.MergeWithStringBuilder(w1, w2));
    }

    [Fact]
    public void PerformanceTest()
    {
        string w1 = new string('a', 1_000_000);
        string w2 = new string('b', 1_000_000);
        // Warmup
        MergeStrings1768.MergeWithCharArray(w1, w2);
        MergeStrings1768.MergeWithStringBuilder(w1, w2);
        // Measure performance
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        MergeStrings1768.MergeWithCharArray(w1, w2);
        stopwatch.Stop();
        Console.WriteLine($"CharArray: {stopwatch.ElapsedMilliseconds} ms");
        stopwatch.Restart();
        MergeStrings1768.MergeWithStringBuilder(w1, w2);
        stopwatch.Stop();
        Console.WriteLine($"StringBuilder: {stopwatch.ElapsedMilliseconds} ms");
    }
}