using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class FindWordsContainingTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new string[] { "leet", "code" },
                    'e',
                    new List<int>() { 0, 1 }
                    );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TesContaining(string[] words, char x, List<int> expectedResult)
        {
            Assert.AreEqual(new FindWordsContainingClass().FindWordsContaining(words, x), expectedResult);
        }
    }
}
