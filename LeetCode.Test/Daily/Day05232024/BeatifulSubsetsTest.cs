using LeetCode.Daily.Day05232024;
using System.Collections;

namespace LeetCode.Test.Daily.Day05232024
{
    public class BeatifulSubsetsTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 2, 4, 6 },
                    2,
                    4
                    );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestRanked(int[] array, int k, int expectedResult)
        {
            Assert.AreEqual(new BeautifulSubsets().BeautifulSubsetsCalc(array, k), expectedResult);
        }
    }
}
