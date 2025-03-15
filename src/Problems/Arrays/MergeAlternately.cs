using System.Text;

namespace DSA.Problems.Arrays;

public static class MergeAlternately
{
    public class Solution
    {
        /// <summary>
        /// You are given two strings word1 and word2. 
        /// Merge the strings by adding letters in alternating order, starting with word1. 
        /// If a string is longer than the other, 
        /// append the additional letters onto the end of the merged string.
        /// https://leetcode.com/problems/merge-strings-alternately/description/
        /// 
        /// Input: word1 = "abc", word2 = "pqr"
        /// Output: "apbqcr"
        /// Explanation: The merged string will be merged as so:
        /// word1:  a   b   c
        /// word2:    p   q   r
        /// merged: a p b q c r
        /// 
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns>Return the merged string.</returns>
        public string MergeAlternately(string word1, string word2)
        {
            // split string to array, if any word is longer then the characters get appended to the end.
            // I can use two pointers 

            if (string.IsNullOrEmpty(word1)) return word2;
            if (string.IsNullOrEmpty(word2)) return word1;

            char[] word1Characters = word1.ToCharArray();
            char[] word2Characters = word2.ToCharArray();
            StringBuilder result = new();

            int i = 0, j = 0;

            while (i < word1Characters.Length && j < word2Characters.Length)
            {
                result.Append(word1Characters[i]);
                result.Append(word2Characters[j]);
                i += 1;
                j += 1;
            }

            while (word1Characters.Length > word2Characters.Length && i < word1Characters.Length)
            {
                result.Append(word1Characters[i]);
                i += 1;
            }

            while (word2Characters.Length > word1Characters.Length && j < word2Characters.Length)
            {
                result.Append(word2Characters[j]);
                j += 1;
            }

            return result.ToString();
        }

        public string MergeAlternatelyV2(string word1, string word2)
        {
            int a = word1.Length;
            int b = word2.Length;

            string output = "";

            for (int i = 0; i < Math.Max(a, b); i++)
            {
                if (i < a)
                {
                    output += word1[i];
                }
                if (i < b)
                {
                    output += word2[i];
                }
            }
            return output;
        }
    }
}
