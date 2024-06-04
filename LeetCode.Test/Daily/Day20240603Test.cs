using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240603Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData("coaching", "coding").Returns(4);
                yield return new TestCaseData("abcde", "a").Returns(0);
                yield return new TestCaseData("z", "abcde").Returns(5);
            }
        }
        [Test, TestCaseSource(nameof(TestCase))]
        public int Test(string s, string t)
        {
            return new Day20240603().AppendCharacters(s, t);
        }
    }
}
