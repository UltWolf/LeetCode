using LeetCode.Daily.Day5212024;
using System.Collections;

namespace LeetCode.Test.Daily.Day5212024
{
    public class Subsets78Test
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 3 }, new List<IList<int>>() {
                    new List<int>(),
                    new List<int>(){ 1 },
                    new List<int>(){ 2 },
                    new List<int>(){ 1,2 },
                    new List<int>(){ 3 },
                    new List<int>(){ 1,3 },
                    new List<int>(){ 2,3 },
                    new List<int>(){ 1,2,3 },
                });
                yield return new TestCaseData(new int[] { 0 }, new List<IList<int>>() {
                    new List<int>(),
                    new List<int>(){0 },
                });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(int[] array, IList<IList<int>> expectedResult)
        {
            Assert.AreEqual(expectedResult, new Subsets78().Subsets(array));
        }
    }
}
