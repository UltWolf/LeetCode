namespace LeetCode.Daily
{
    //    Example 1:

    //Input: s = "coaching", t = "coding"
    //Output: 4
    //Explanation: Append the characters "ding" to the end of s so that s = "coachingding".
    //Now, t is a subsequence of s("coachingding").
    //It can be shown that appending any 3 characters to the end of s will never make t a subsequence.
    //Example 2:

    //Input: s = "abcde", t = "a"
    //Output: 0
    //Explanation: t is already a subsequence of s ("abcde").
    //Example 3:

    //Input: s = "z", t = "abcde"
    //Output: 5
    //Explanation: Append the characters "abcde" to the end of s so that s = "zabcde".
    //Now, t is a subsequence of s("zabcde").
    //It can be shown that appending any 4 characters to the end of s will never make t a subsequence.
    public class Day20240603
    {
        public int AppendCharacters(string s, string t)
        {
            int sIndex = 0, tIndex = 0;
            int sLength = s.Length, tLength = t.Length;

            while (sIndex < sLength && tIndex < tLength)
            {
                if (s[sIndex] == t[tIndex])
                {
                    tIndex++;
                }
                sIndex++;
            }

            return tLength - tIndex;

            //var similarRoot = 0;
            //for (var i = 0; i < s.Length && i < t.Length; i++)
            //{
            //    if (s[i] != t[i])
            //    {
            //        similarRoot = i;
            //        break;
            //    }
            //}
            //if (similarRoot == t.Length)
            //{
            //    return 0;
            //}
            //return t.Length - similarRoot;
        }
    }
}
