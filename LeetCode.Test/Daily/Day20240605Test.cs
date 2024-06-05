using LeetCode.Daily;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day20240605Test
    {
        public static IEnumerable TestCase
        {
            get
            {
                yield return new TestCaseData("", new string[] { "bella", "label", "roller" }) { TestName = "test" }.Returns(new string[] { "e", "l", "l" });
                yield return new TestCaseData("", new string[] { "cool", "lock", "cook" }) { TestName = "test2" }.Returns(new string[] { "c", "o" });
            }
        }
        [Test, TestCaseSource(nameof(TestCase))]
        public string[] CheckDuplicates(string s, string[] array)
        {
            return new Day20240605().Calculate(array).ToArray();
        }

    }
}
