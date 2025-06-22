namespace Problems;

/// <summary>
/// LeetCode problem 345. Reverse Vowels of a String. Reverse only the vowels of
/// a given string while leaving other characters in place.
/// </summary>
/// <remarks>
/// Category: Two Pointers
/// LeetCode link: https://leetcode.com/problems/reverse-vowels-of-a-string/
/// </remarks>
public class P0345_Reverse_Vowels_of_a_String
{
    /// <summary>
    /// Determines whether the specified character is a vowel.
    /// </summary>
    /// <param name="c">The character to evaluate.</param>
    /// <returns><see langword="true"/> if the specified character is a vowel  (either uppercase or lowercase); otherwise, <see
    /// langword="false"/>.</returns>
    public static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
    }

    /// <summary>
    /// Swaps the positions of two characters in the specified array.
    /// </summary>
    /// <remarks>This method modifies the input array in place by exchanging the characters at the specified
    /// indices. Ensure that both <paramref name="x"/> and <paramref name="y"/> are within the bounds of the array to
    /// avoid runtime errors.</remarks>
    /// <param name="chars">The array of characters in which the swap will occur. Cannot be null.</param>
    /// <param name="x">The index of the first character to swap. Must be a valid index within the array.</param>
    /// <param name="y">The index of the second character to swap. Must be a valid index within the array.</param>
    private static void Swap(char[] chars, int x, int y)
    {
        char temp = chars[x];
        chars[x] = chars[y];
        chars[y] = temp;
    }

    /// <summary>
    /// Reverses the order of vowels in the specified string while preserving the positions of non-vowel characters.
    /// </summary>
    /// <remarks>This method considers the English vowels ('a', 'e', 'i', 'o', 'u', both uppercase and
    /// lowercase) when reversing.
    /// <para>Time complexity: O(n).</para>
    /// <para>Space complexity: O(n) for the character array copy.</para></remarks>
    /// <param name="s">The input string whose vowels will be reversed. Cannot be null.</param>
    /// <returns>A new string with the vowels reversed and all other characters in their original positions.</returns>
    public static string ReverseVowels(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        char[] sChar = s.ToCharArray();

        while (left < right)
        {
            while (left < right && !IsVowel(sChar[left]))
            {
                left++;
            }

            while (left < right && !IsVowel(sChar[right]))
            {
                right--;
            }

            if (left < right)
            {
                Swap(sChar, left, right);
                left++;
                right--;
            }
        }

        return new string(sChar);
    }
}

