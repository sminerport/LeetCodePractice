using System.Text;

namespace Problems;

/// <summary>
/// Provides methods for reversing the order of words in a string while removing extra spaces.
/// </summary>
/// <remarks>This class includes multiple implementations for reversing words in a string, each with different
/// approaches. Words are defined as sequences of non-space characters, and consecutive spaces are treated as a single
/// delimiter. For example, the input "  Hello   World  " will produce "World Hello".</remarks>
public static class P0151_Reverse_Words_in_a_String
{
    /// <summary>
    /// Reverses the order of words in the specified string, removing any extra spaces.
    /// </summary>
    /// <remarks>Words are defined as sequences of non-space characters. Consecutive spaces in the input are
    /// treated as a single delimiter. For example, the input "  Hello   World  " will produce "World Hello".</remarks>
    /// <param name="s">The input string containing words separated by spaces. Can include leading, trailing, or multiple consecutive
    /// spaces.</param>
    /// <returns>A string with the words in reverse order, separated by a single space. Extra spaces are removed.</returns>
    public static string ReverseWords_SplitReverse(string s)
    {
        // Split the string into words, dropping empty entries
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Reverse the array of words
        Array.Reverse(words);

        // Join the reversed words with a single space
        return string.Join(" ", words);
    }

    /// <summary>
    /// Reverses the order of words in the specified string, removing any empty or whitespace-only entries.
    /// </summary>
    /// <remarks>This method splits the input string by spaces, filters out empty or whitespace-only entries,
    /// reverses the order of the remaining words,  and joins them into a single string separated by spaces.</remarks>
    /// <param name="s">The input string containing words separated by spaces.</param>
    /// <returns>A string with the words in reverse order, separated by a single space. Empty or whitespace-only entries are
    /// excluded.</returns>
    public static string ReverseWords_FilterJoin(string s)
    {
        // Use LINQ to filter out empty entries and reverse the order of words
        var words = s.Split(' ')
            .Where(word => String.IsNullOrWhiteSpace(word) == false)
            .Reverse();

        return string.Join(" ", words);
    }

    public static string ReverseWords_InPlaceReverse(string s)
    {
        StringBuilder sb = TrimSpaces(s);
        // Reverse the entire string
        Reverse(sb, 0, sb.Length - 1);
        // Reverse each word in the reversed string
        ReverseEachWord(sb);
        return sb.ToString();
    }

    private static StringBuilder TrimSpaces(string s)
    {
        int left = 0, right = s.Length - 1;
        // Trim leading spaces
        while (left < s.Length && char.IsWhiteSpace(s[left]))
        {
            left++;
        }

        // Trim trailing space
        while (right >= 0 && char.IsWhiteSpace(s[right]))
        {
            right--;
        }
        // Create a StringBuilder with the trimmed substring
        StringBuilder sb = new StringBuilder();
        // reduce multiple spaces to a single space
        while (left <= right)
        {
            if (s[left] != ' ')
            {
                sb.Append(s[left]);
            }
            else if (sb[sb.Length - 1] != ' ')
            {
                sb.Append(s[left]);
            }
            left++;
        }

        return sb;
    }

    private static void ReverseEachWord(StringBuilder sb)
    {
        int n = sb.Length;
        int start = 0, end = 0;
        while (start < n)
        {
            // Go to the end of the word
            while (end < n && sb[end] != ' ')
            {
                end++;
            }

            // Reverse the word from start to end - 1
            Reverse(sb, start, end - 1);

            // Move to the next word
            start = end + 1; // Skip the space
            end++;
        }
    }

    private static void Reverse(StringBuilder sb, int left, int right)
    {
        while (left < right)
        {
            // Swap characters at left and right indices
            char temp = sb[left];
            sb[left++] = sb[right];
            sb[right--] = temp;
        }
    }
}