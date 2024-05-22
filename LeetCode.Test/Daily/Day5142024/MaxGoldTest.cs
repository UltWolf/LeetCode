using LeetCode.Daily.Day5142024;
using System.Collections;

namespace LeetCode.Test.Daily.Day05142024
{
    public class MaxGoldTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(
                    new int[][] { [0, 6, 0], [5, 8, 7], [0, 9, 0] },
                     24
                    );
                yield return new TestCaseData(
             new int[][] { [1, 0, 7, 0, 0, 0], [2, 0, 6, 0, 1, 0], [3, 5, 6, 7, 4, 2], [4, 3, 1, 0, 2, 0], [3, 0, 5, 0, 20, 0] },
                60
               );
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestGold(int[][] array, int expectedResult)
        {
            Assert.AreEqual(new MaximumGold().GetMaximumGold(array), expectedResult);
        }
    }
}
