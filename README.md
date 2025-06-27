# LeetCode Practice

This repository contains a collection of C# solutions to various LeetCode problems. Each problem is implemented in the **Problems** project with accompanying unit tests in the **Tests** project. A small console **Runner** is available for ad‑hoc experiments, and a **Benchmarks** project uses BenchmarkDotNet to measure performance of selected implementations.

## Projects

| Project    | Description |
|------------|-------------|
| `Problems` | Implementations of algorithmic problems. Each class contains XML documentation and multiple methods when relevant. Target framework is `net9.0`. |
| `Tests`    | xUnit tests covering the solutions. Run with `dotnet test`. |
| `Runner`   | Console application for manual testing or demonstration. Execute with `dotnet run --project Runner`. |
| `Benchmarks` | BenchmarkDotNet project for performance comparisons. Run with `dotnet run -c Release --project Benchmarks`. |

The solution file `LeetCodePractice.sln` groups all projects together.

## Building and Testing

Ensure the .NET SDK (version 9.0 preview or later) is installed. From the repository root:

```bash
# Restore dependencies
 dotnet restore

# Run unit tests
 dotnet test
```

To execute the console runner or benchmarks:

```bash
# Run the sample console app
 dotnet run --project Runner

# Run benchmarks (Release configuration recommended)
dotnet run -c Release --project Benchmarks
```

A `.gitignore` file is included to exclude common build artifacts such as `bin/`
and `obj/` directories.

## Problem List

Implemented solutions currently include:

<!-- The list below is generated from the filenames in the `Problems` folder. -->
- [x] 0001. Two Sum
- [x] 0026. Remove Duplicates from Sorted Array
- [x] 0027. Remove Element
- [x] 0035. Search Insert Position
- [x] 0088. Merge Sorted Array
- [x] 0151. Reverse Words in a String
- [x] 0238. Product of Array Except Self
- [x] 0334. Increasing Triplet Subsequence
- [x] 0344. Reverse String
- [x] 0345. Reverse Vowels of a String
- [x] 0346. Moving Average from Data Stream
- [x] 0485. Max Consecutive Ones
- [x] 0605. Can Place Flowers
- [x] 0643. Maximum Average Subarray I
- [x] 0977. Squares of a Sorted Array
- [x] 1004. Max Consecutive Ones III
- [x] 1071. Greatest Common Divisor of Strings
- [x] 1089. Duplicate Zeros
- [x] 121. Best Time To Buy And Sell Stock
- [x] 1295. Find Numbers with Even Number of Digits
- [x] 1431. Kids With the Greatest Number of Candies
- [x] 1456. Maximum Number of Vowels in a Substring of Given Length
- [x] 1480. Running Sum of 1d Array
- [x] 1679. Max Number of K-Sum Pairs
- [x] 1768. MergeStrings

Each class in the `Problems` folder is paired with tests where available.

## License

This project is provided for educational purposes without any specific license. Feel free to use the code as a reference for your own practice.
