using LeetCode.Common.Tasks;

namespace LeetCode.Test.Common
{
    public class LongestCommonPrefixTest
    {
        public static IEnumerable<TestCaseData> TestCase
        {
            get
            {
                yield return new TestCaseData("fl", new string[] { "flower", "flow", "flight" }) { TestName = "test1" }.Returns("fl");
                yield return new TestCaseData("", new string[] { "dog", "racecar", "car" }) { TestName = "test2" }.Returns("");
            }
        }

        [Test, TestCaseSource(nameof(TestCase))]
        public string LongestCommonPrefix(string result, string[] strs)
        {
            return new LongestCommonPrefixWrapper().LongestCommonPrefix(strs);
        }
    }
}
