using LeetCode.Daily.Day5222024;
using System.Collections;

namespace LeetCode.Test.Daily.Day05222024
{
    public class PalindromePartitioningTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("aab", new List<IList<string>>() {
                    new List<string>(){"a","a","b" },
                    new List<string>(){"aa","b" },
                });
                yield return new TestCaseData("a", new List<IList<string>>() {
                    new List<string>(){"a" },
                });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(string s, IList<IList<string>> expectedResult)
        {
            Assert.AreEqual(expectedResult, new PalindromePartitioning().Partition(s));
        }
    }
}
