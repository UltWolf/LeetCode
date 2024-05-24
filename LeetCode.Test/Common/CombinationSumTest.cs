using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class CombinationSumTest
    {
        private static IEnumerable TestCases
        {

            get
            {
                yield return new TestCaseData(new[] { 2, 5, 1, 2 }, 5,
                     new List<IList<int>>() {
                         new List<int>() { 1,2, 2 },
                         new List<int>() { 5} });
                yield return new TestCaseData(new[] { 10, 1, 2, 7, 6, 1, 5 }, 8,
                   new List<IList<int>>() {
                         new List<int>() { 1,1, 6 },
                         new List<int>() { 1,2, 5 },
                         new List<int>() { 1,7 },
                         new List<int>() { 2,6 } });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(int[] num, int target, IList<IList<int>> expectedResult)
        {
            Assert.AreEqual(expectedResult, new CombinationSum2().CombinationSum(num, target));
        }
    }
}
