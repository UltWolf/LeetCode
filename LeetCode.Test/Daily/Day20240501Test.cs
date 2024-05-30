using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240501Test
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                   "abcdefd", 'd'
                    ).Returns("dcbaefd");
                yield return new TestCaseData(
                  "xyxzxe", 'z'
                   ).Returns("zxyxxe");
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public string TestRanked(string word, char ch)
        {
            return new Day20240501().ReversePrefix(word, ch);
        }
    }
}
