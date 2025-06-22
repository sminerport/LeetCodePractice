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

## Problem List

Implemented solutions currently include:

- [x] 27. Remove Element (`P0027_Remove_Element`) — **Category:** Two Pointers
- [x] 88. Merge Sorted Array (`P0088_Merge_Sorted_Array`) — **Category:** Two Pointers
- [x] 485. Max Consecutive Ones (`P0485_Max_Consecutive_Ones`) — **Category:** Sliding Window
- [x] 605. Can Place Flowers (`P0605_Can_Place_Flowers`) — **Category:** Greedy
- [x] 643. Maximum Average Subarray I (`P0643_Maximum_Average_Subarray_I`) — **Category:** Sliding Window
- [x] 977. Squares of a Sorted Array (`P0977_Squares_of_a_Sorted_Array`) — **Category:** Two Pointers
- [x] 1004. Max Consecutive Ones III (`P1004_Max_Consecutive_Ones_III`) — **Category:** Sliding Window
- [x] 1071. Greatest Common Divisor of Strings (`P1071_Greatest_Common_Divisor_of_Strings`) — **Category:** String Manipulation
- [x] 1089. Duplicate Zeros (`P1089_Duplicate_Zeros`) — **Category:** In-place Array
- [x] 1295. Find Numbers with Even Number of Digits (`P1295_Find_Numbers_with_Even_Number_of_Digits`) — **Category:** Counting
- [x] 1431. Kids With the Greatest Number of Candies (`P1431_Kids_With_the_Greatest_Number_of_Candies`) — **Category:** Array
- [x] 1480. Running Sum of 1d Array (`P1480_Running_Sum_of_1d_Array`) — **Category:** Prefix Sum
- [x] 1768. Merge Strings Alternately (`P1768_MergeStrings`) — **Category:** Two Pointers

Each class in the `Problems` folder is paired with tests where available.

## License

This project is provided for educational purposes without any specific license. Feel free to use the code as a reference for your own practice.
