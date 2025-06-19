using System.Diagnostics;

using Problems;

internal class Program
{
    private static void Main()
    {
        string? w1 = new string('a', 1_000_000);
        string? w2 = new string('b', 1_000_000);

        Test("CharArray", MergeStrings1768.MergeWithCharArray, w1, w2);
        Test("StringBuilder", MergeStrings1768.MergeWithStringBuilder, w1, w2);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    private static void Test(string label, Func<string, string, string> mergeFunc, string word1, string word2)
    {
        // Warmup
        mergeFunc(word1, word2);

        Stopwatch stopwatch = Stopwatch.StartNew();

        mergeFunc(word1, word2);

        stopwatch.Stop();

        Console.WriteLine($"{label}: {stopwatch.ElapsedMilliseconds} ms");
    }
}