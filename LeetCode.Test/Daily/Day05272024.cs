using LeetCode.Daily.Day05272024;
using System.Collections;

namespace LeetCode.Test.Daily
{
    public class Day05272024Test
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 3, 5 }, 2
                    );
                yield return new TestCaseData(
                  new int[] { 0, 0 }, -1
                  );
                yield return new TestCaseData(
                    new int[] { 0, 4, 3, 0, 4 }, 3
                  );
                yield return new TestCaseData(
                    new int[] { 3, 6, 7, 7, 0 }, -1
                  );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestRanked(int[] n, int expectedResult)
        {
            Assert.AreEqual(new SpecialArray().CalcSpecialArray(n), expectedResult);
        }
    }
}
