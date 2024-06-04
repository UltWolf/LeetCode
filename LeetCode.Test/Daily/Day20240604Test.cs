using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240604Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData("abccccdd").Returns(7);
                yield return new TestCaseData("a").Returns(1);
                yield return new TestCaseData("ccc").Returns(3);
            }
        }
        [Test, TestCaseSource(nameof(TestCase))]
        public int GetTest(string s)
        {
            return new Day20240604().LongestPalindrome(s);
        }
    }
}
