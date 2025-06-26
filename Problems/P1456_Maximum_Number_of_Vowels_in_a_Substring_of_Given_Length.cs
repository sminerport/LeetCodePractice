namespace Problems;

/// <summary>
/// Provides methods to analyze substrings within a string and determine vowel-related metrics.
/// </summary>
/// <remarks>This class includes functionality to calculate the maximum number of vowels in a substring of a
/// specified length. Vowels are defined as 'a', 'e', 'i', 'o', and 'u' (case-insensitive). The methods in this class
/// are designed for efficient processing of strings using techniques such as the sliding window approach.</remarks>
public class P1456_Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    /// <summary>
    /// Calculates the maximum number of vowels in any contiguous substring of a specified length.
    /// </summary>
    /// <remarks>Vowels are defined as the characters 'a', 'e', 'i', 'o', and 'u', case-insensitively. The
    /// method uses a sliding window approach for efficient computation.</remarks>
    /// <param name="s">The input string to analyze. Cannot be <see langword="null"/>.</param>
    /// <param name="k">The length of the substring to consider. Must be greater than 0 and less than or equal to the length of
    /// <paramref name="s"/>.</param>
    /// <returns>The maximum number of vowels found in any contiguous substring of length <paramref name="k"/>. Returns 0 if
    /// <paramref name="k"/> is invalid or if <paramref name="s"/> contains no vowels.</returns>
    public int MaxVowels_StaticWindow(string s, int k)
    {
        if (k <= 0 || s == null || s.Length < k)
            return 0;

        // 1) Fast vowel Lookup
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        // 2) Count the number of vowels in the first k characters
        int count = 0;
        for (int i = 0; i < k; i++)
        {
            if (vowels.Contains(char.ToLower(s[i])))
            {
                count++;
            }
        }

        // 3) Initialize maxCount with the initial count
        int max = count;

        // 4) Slide the window across the string
        for (int i = k; i < s.Length; i++)
        {
            if (vowels.Contains(char.ToLower(s[i])))
                count++;
            if (vowels.Contains(char.ToLower(s[i - k])))
                count--;
            if (count > max)
                max = count;
        }
        return max;
    }

    /// <summary>
    /// Determines whether the specified character is a vowel.
    /// </summary>
    /// <param name="c">The character to evaluate.</param>
    /// <returns><see langword="true"/> if the specified character is a vowel (a, e, i, o, or u);  otherwise, <see
    /// langword="false"/>.</returns>
    private bool IsVowel(char c)
    {
        return "aeiou".IndexOf(c) >= 0;
    }

    /// <summary>
    /// Finds the maximum number of vowels in any substring of the specified length within the given string.
    /// </summary>
    /// <remarks>This method uses a sliding window approach to efficiently calculate the result. Vowels are
    /// defined as 'a', 'e', 'i', 'o', and 'u' (case-insensitive).</remarks>
    /// <param name="s">The input string to analyze. Cannot be <see langword="null"/>.</param>
    /// <param name="k">The length of the substring to consider. Must be greater than 0 and less than or equal to the length of
    /// <paramref name="s"/>.</param>
    /// <returns>The maximum number of vowels found in any substring of length <paramref name="k"/>. Returns 0 if <paramref
    /// name="k"/> is invalid or if <paramref name="s"/> contains no vowels.</returns>
    public int MaxVowels_DynamicWindow(string s, int k)
    {
        if (k <= 0 || s == null || s.Length < k)
            return 0;

        int left = 0, count = 0, maxCount = 0;
        for (int right = 0; right < s.Length; right++)
        {
            // If the character is a vowel, increment the count
            if (IsVowel(s[right]))
                count++;

            // If the window size exceeds k, move the left pointer
            while (right - left + 1 > k)
            {
                if (IsVowel(s[left]))
                    count--;
                left++;
            }

            if (count > maxCount)
                maxCount = count;
        }
        return maxCount;
    }
}