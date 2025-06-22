using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems;

public class P1071_Greatest_Common_Divisor_of_Strings
{
    /// <summary>
    /// Determines whether the specified strings can be constructed by repeating a common substring of the specified
    /// length.
    /// </summary>
    /// <remarks>This method checks whether the given strings can be decomposed into repeated instances of a
    /// common substring of the specified length. If the length does not evenly divide the length of either string, the
    /// method returns <see langword="false"/>.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(n).</para></remarks>
    /// <param name="str1">The first string to validate.</param>
    /// <param name="str2">The second string to validate.</param>
    /// <param name="length">The length of the substring to check for repetition. Must be greater than 0.</param>
    /// <returns><see langword="true"/> if both <paramref name="str1"/> and <paramref name="str2"/> can be constructed by
    /// repeating the same substring of the specified length; otherwise, <see langword="false"/>.</returns>
    public bool IsValid(string str1, string str2, int length)
    {
        if (str1.Length % length != 0 || str2.Length % length != 0)
        {
            return false;
        }
        string substring = str1.Substring(0, length);
        int repeatCount1 = str1.Length / length;
        int repeatCount2 = str2.Length / length;

        return str1 == string.Concat(Enumerable.Repeat(substring, repeatCount1)) &&
            str2 == string.Concat(Enumerable.Repeat(substring, repeatCount2));
    }

    /// <summary>
    /// Finds the greatest common divisor (GCD) of two strings using a brute-force approach.
    /// </summary>
    /// <remarks>The method iteratively checks substrings of decreasing length to determine the largest common
    /// divisor. This approach may have performance implications for very large strings.
    /// <para>Time complexity: O(n<sup>2</sup>).</para>
    /// <para>Space complexity: O(n).</para></remarks>
    /// <param name="str1">The first input string.</param>
    /// <param name="str2">The second input string.</param>
    /// <returns>A string representing the largest substring that can be repeatedly concatenated to form both <paramref
    /// name="str1"/> and <paramref name="str2"/>. Returns an empty string if no such substring exists.</returns>

    public string GcdOfStringsBruteForce(string str1, string str2)
    {
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = minLength; i > 0; i--)
        {
            if (IsValid(str1, str2, i))
            {
                return str1.Substring(0, i);
            }
        }

        return "";
    }
}