namespace Problems;

/// <summary>
/// Provides functionality to reverse the vowels in a given string.
/// </summary>
/// <remarks>This class is designed to manipulate strings by reversing the order of vowels while preserving the
/// positions of non-vowel characters. It can be used in scenarios where vowel-specific transformations are
/// required.</remarks>
public class P345_Reverse_Vowels_of_a_String
{
    /// <summary>
    /// Determines whether the specified character is a vowel.
    /// </summary>
    /// <param name="c">The character to evaluate.</param>
    /// <returns><see langword="true"/> if the specified character is a vowel  (either uppercase or lowercase); otherwise, <see
    /// langword="false"/>.</returns>
    public bool IsVowel(char c)
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
    public void swap(char[] chars, int x, int y)
    {
        char temp = chars[y];
        chars[x] = chars[y];
        chars[x] = temp;
    }

    /// <summary>
    /// Reverses the order of vowels in the specified string while preserving the positions of non-vowel characters.
    /// </summary>
    /// <remarks>This method considers the English vowels ('a', 'e', 'i', 'o', 'u', both uppercase and
    /// lowercase) when reversing. Non-vowel characters remain unchanged in their original positions.</remarks>
    /// <param name="s">The input string whose vowels will be reversed. Cannot be null.</param>
    /// <returns>A new string with the vowels reversed and all other characters in their original positions.</returns>
    public string ReverseVowel(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        char[] sChar = s.ToCharArray();

        while (left < right)
        {
            while (left < s.Length - 1 && !IsVowel(sChar[left]))
            {
                left++;
            }

            while (right >= 0 && !IsVowel(sChar[right]))
            {
                right--;
            }

            if (left < right)
            {
                swap(sChar, left++, right++);
            }
        }

        return new string(sChar);
    }
}