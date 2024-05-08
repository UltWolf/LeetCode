using LeetCode.Daily.Day582024;
using System.Collections;

namespace LeetCode.Test.Daily.Day582024
{
    public class RanksTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[] { 5, 4, 3, 2, 1 },
                    new string[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5" }
                    );
                yield return new TestCaseData(
                    new int[] { 10, 3, 8, 9, 4 },
                    new string[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" }
                    );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestRanked(int[] array, string[] expectedArray)
        {
            Assert.AreEqual(new Ranks().FindRelativeRanks(array), expectedArray);
        }
    }
}
