using LeetCode.Common.Tasks;
using System.Collections;

namespace LeetCode.Test.Common
{
    public class PermutationTest
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 1, 2, 3 },
                     new List<IList<int>>() {
                         new List<int>() { 1,2, 3 },
                         new List<int>() { 1,3, 2 },
                         new List<int>() { 2,1,3 },
                         new List<int>() { 2,3,1 },
                         new List<int>() { 3,1,2 },
                         new List<int>() { 3,2,1 } });

                yield return new TestCaseData(new[] { 0, 1 }, new List<IList<int>>() { new List<int>() { 0, 1 }, new List<int>() { 1, 0 } });
                yield return new TestCaseData(new[] { 1 }, new List<IList<int>>() { new List<int>() { 1 } });
            }
        }
        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestBoats(int[] num, IList<IList<int>> expectedResult)
        {
            Assert.AreEqual(expectedResult, new Permutations().Permute(num));
        }
    }
}
