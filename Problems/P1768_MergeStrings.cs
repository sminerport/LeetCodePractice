namespace Problems;

public static class MergeStrings1768
{
    /// <summary>
    /// Merges two strings by alternating characters from each string.
    /// <para>Time complexity: O(n) where n is the length of the longer string.</para>
    /// <para>Space complexity: O(n) for the result string.</para>
    /// </summary>
    /// <param name="word1">The first string to merge.</param>
    /// <param name="word2">The second string to merge.</param>
    /// <returns>The merged string with characters from both input strings.</returns>
    public static string MergeWithCharArray(string word1, string word2)
    {
        char[] result = new char[word1.Length + word2.Length];
        int i = 0, j = 0, k = 0;
        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                result[k++] = word1[i++];
            }
            if (j < word2.Length)
            {
                result[k++] = word2[j++];
            }
        }
        return new string(result);
    }

    /// <summary>
    /// Merges two strings by alternating characters from each string using StringBuilder.
    /// <para>Time complexity: O(n) where n is the length of the longer string.</para>
    /// <para>Space complexity: O(n) for the StringBuilder result.</para>
    /// </summary>
    /// <param name="word1">The first string to merge.</param>
    /// <param name="word2">The second string to merge.</param>
    /// <returns>The merged string with characters from both input strings.</returns>

    public static string MergeWithStringBuilder(string word1, string word2)
    {
        var sb = new System.Text.StringBuilder();
        int i = 0, j = 0;
        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                sb.Append(word1[i++]);
            }
            if (j < word2.Length)
            {
                sb.Append(word2[j++]);
            }
        }
        return sb.ToString();
    }
}