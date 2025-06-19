using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using Problems;

[MemoryDiagnoser]
public class MergeBenchmarks
{
    private string w1 = String.Empty, w2 = String.Empty;

    [GlobalSetup]
    public void Setup()
    {
        w1 = new string('a', 1_000_000);
        w2 = new string('b', 1_000_000);

        // Warm up both once
        MergeStrings1768.MergeWithCharArray(w1, w2);
        MergeStrings1768.MergeWithStringBuilder(w1, w2);
    }

    [Benchmark(Baseline = true)]
    public string CharArray() =>
        MergeStrings1768.MergeWithCharArray(w1, w2);

    [Benchmark]
    public string StringBuilder() =>
        MergeStrings1768.MergeWithStringBuilder(w1, w2);
}

public class Program
{
    public static void Main(string[] args) => BenchmarkRunner.Run<MergeBenchmarks>();
}